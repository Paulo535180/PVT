using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Route("Modulo")]
    [Authorize]
    public class ModuloController : Controller
    {
        private readonly IModuloRepository _modulo;
        private readonly ISetorModuloRepository _setorModuloRepository;
        public ModuloController(IModuloRepository modulo, ISetorModuloRepository setorModulo)
        {
            _modulo = modulo;
            _setorModuloRepository = setorModulo;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Listagem")]
        public async Task<IActionResult> Listagem()
        {
            return Ok(await _modulo.ListagemModulos());
        }


        [HttpGet("MeusModulos")]
        public async Task<IActionResult> MeusModulos([FromServices] ISetorRepository _setorRepository)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var setor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            var Setor = await _setorRepository.SelectId(setor);
            ViewBag.Setor = Setor.NOME;
            return View();

        }


        [HttpGet("ListagemPorUser")]
        public async Task<IActionResult> ListagemPorUser()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var gestor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            return Ok(await _modulo.ListagemModulosPorUser(gestor));
        }


        [HttpGet("ListagemPorSetor")]
        public async Task<IActionResult> ListagemPorSetor()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var setor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            return Ok(await _modulo.ListagemModulosPorSetor(setor));
        }

        [HttpGet("ListagemModulosSemVinculo")]
        public async Task<IActionResult> ListagemModulosSemVinculos()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var setor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            return Ok(await _modulo.ListagemModulosSemVinculo(setor));
        }


        [HttpPost("")]
        public async Task<IActionResult> AdicionarModulo([FromBody] Modulo modulo)
        {
            var claims = (ClaimsIdentity)User.Identity;
            modulo.USUARIO_CRIACAO = User.Identity.Name;
            modulo.ID_USUARIO_GESTOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            modulo.DATA_CRIACAO = DateTime.Now;

            if (!ModelState.IsValid) return UnprocessableEntity();
            await _modulo.Insert(modulo);

            var setorModulo = new SetorModulo
            {
                ID_MODULO = modulo.ID,
                ID_SETOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value),
                DATA_CRIACAO = DateTime.Now,
                USUARIO_CRIACAO = User.Identity.Name,
            };
            await _setorModuloRepository.Insert(setorModulo);

            return Created("/Modulo/Index", modulo);
        }

        [HttpPost("{Id:int}/VincularModulo")]
        public async Task<IActionResult> VincularModulo (int Id)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var novoSetorModulo = new SetorModulo
            {
                ID_MODULO = Id,
                ID_SETOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value),
            };
            var setorModulo = await _setorModuloRepository.BuscarSetorModulo(novoSetorModulo);

            if(setorModulo == null)
            {
                novoSetorModulo.DATA_CRIACAO = DateTime.Now;
                novoSetorModulo.USUARIO_CRIACAO = User.Identity.Name;
                novoSetorModulo.STATUS = true;
                await _setorModuloRepository.Insert(novoSetorModulo);
            }
            else {
                setorModulo.STATUS = true;
                setorModulo.DATA_ALTERACAO = DateTime.Now;
                setorModulo.USUARIO_CRIACAO = User.Identity.Name;
                await _setorModuloRepository.Update(setorModulo);
            };
            return Created("/Modulo/Index", setorModulo);
        }

        //[HttpPut("")]
        //public async Task<IActionResult> AlterarStatus([FromBody] Modulo modulo)
        //{
        //    var claims = (ClaimsIdentity)User.Identity;

        //    if (modulo.ID_USUARIO_GESTOR == Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value))
        //    {
        //        modulo.STATUS = !modulo.STATUS;
        //        return await EditarModulo(modulo.ID, modulo);
        //    }
        //    else
        //    {
        //        var setorModulo = new SetorModulo
        //        {
        //            ID_MODULO = modulo.ID,
        //            ID_SETOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value),
        //        };
        //        setorModulo = await _setorModuloRepository.BuscarSetorModulo(setorModulo);
        //        setorModulo.STATUS = !setorModulo.STATUS;
        //        await _setorModuloRepository.Update(setorModulo);
        //    }
        //    return Accepted("/Modulo/Index", modulo);
        //}




        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditarModulo(int id, [FromBody] Modulo modulo)
        {
            modulo.USUARIO_ALTERACAO = User.Identity.Name;
            modulo.DATA_ALTERACAO = DateTime.Now;

            if (id != modulo.ID)
            {
                return Conflict();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    await _modulo.Update(modulo);

                    return Accepted();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuloExists(modulo.ID))
                    {
                        return NotFound();
                    }
                }
            }
            return UnprocessableEntity();
        }

        [HttpGet("Buscamodulo")]
        public async Task<IActionResult> Buscamodulo(int id)
        {
            return Ok(await _modulo.SelectId(id));
        }

        private bool ModuloExists(int id)
        {
            return _modulo.SelectId(id) != null;
        }


        [HttpPatch("{Id:int}/AlterarStatus")]
        public async Task<IActionResult> AlterarStatus(int Id, [FromServices] IUsuarioGestorRepository usuarioGestorRepository)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var modulo = await _modulo.SelectId(Id);
            var usuarioGestor = await usuarioGestorRepository.SelectId(modulo.ID_USUARIO_GESTOR);
            var Idsetor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            var idGestor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            modulo.USUARIO_ALTERACAO = User.Identity.Name;
            modulo.DATA_ALTERACAO = DateTime.Now;

            if (usuarioGestor.ID_SETOR != Idsetor)
            {
                var setorModulo = new SetorModulo
                {
                    ID_MODULO = modulo.ID,
                    ID_SETOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value),
                };
                setorModulo = await _setorModuloRepository.BuscarSetorModulo(setorModulo);
                setorModulo.STATUS = !setorModulo.STATUS;
                await _setorModuloRepository.Update(setorModulo);
            }

            else if (modulo.ID_USUARIO_GESTOR == idGestor)
            {
                modulo.STATUS = !modulo.STATUS;

                await _modulo.Update(modulo);
            }
            else return BadRequest();

            return StatusCode(202); //--> 202 aceito
        }

    }
}
