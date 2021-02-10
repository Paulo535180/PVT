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

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> MeusModulos([FromServices] ISetorRepository _setorRepository)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var setor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            var Setor = await  _setorRepository.SelectId(setor);
            ViewBag.Setor = Setor.NOME;
            return View();

        }

        public async Task<IActionResult> Listagem()
        {
            return Ok(await _modulo.ListagemModulos());
        }



        [HttpGet]
        public async Task<IActionResult> ListagemPorUser()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var gestor =  Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            return Ok(await _modulo.ListagemModulosPorUser(gestor));
        }


        [HttpGet]
        public async Task<IActionResult> ListagemPorSetor()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var setor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            return Ok(await _modulo.ListagemModulosPorSetor(setor));
        }


        [HttpPost]
        public async Task<IActionResult> AdicionarModulo([FromBody] Modulo modulo)
        {
            var claims = (ClaimsIdentity)User.Identity;
            modulo.USUARIO_CRIACAO = User.Identity.Name;
            modulo.ID_USUARIO_GESTOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            modulo.DATA_CRIACAO = DateTime.Now;
            
            if (ModelState.IsValid) return View(modulo);
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

        [HttpPut]
        public async Task<IActionResult> AlterarStatus ([FromBody] Modulo modulo)
        {
            var claims = (ClaimsIdentity)User.Identity;

            if (modulo.ID_USUARIO_GESTOR == Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value))
            {
                modulo.STATUS = !modulo.STATUS;
                return await EditarModulo(modulo.ID, modulo);
            }
            else
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
            return Accepted("/Modulo/Index", modulo);
        }


        [HttpPut]
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

        [HttpGet]
        public async Task<IActionResult> Buscamodulo(int id)
        {
            return Ok(await _modulo.SelectId(id));
        }

            private bool ModuloExists(int id)
        {
            return _modulo.SelectId(id) != null;
        }


    }
}
