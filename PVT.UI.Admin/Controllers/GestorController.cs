using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Route("Gestor")]
    [Authorize]
    public class GestorController : Controller
    {
        private readonly IUsuarioGestorRepository _gestor;
        private readonly IUsuarioRepository _usuarioRepository;
        public GestorController(IUsuarioGestorRepository gestor, IUsuarioRepository usuarioRepository)
        {
            _gestor = gestor;
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Listagem/{idSetor:int}")]
        public async Task<IActionResult> ListagemPorSetor(int idSetor)
        {

            return Ok(await _gestor.ListagemGestoresPorSetor(idSetor));
        }


        [HttpGet("GestorPorSetor")]
        public async Task<IActionResult> ListagemPorUser()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var IdSetor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);
            var IdGestor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            return Ok(await _gestor.ListagemGestoresPorSetor(IdSetor, IdGestor));
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] UsuarioGestor usuarioGestorView)
        {
            var userbd = await _gestor.ObterUsuarioGestor(usuarioGestorView);
            if (userbd == null)
            {
                usuarioGestorView.USUARIO_CRIACAO = User.Identity.Name;
                usuarioGestorView.DATA_CRIACAO = DateTime.Now;
                usuarioGestorView.STATUS = true;
                
                await _gestor.Insert(usuarioGestorView);
                return Accepted();
            }
            else
            {
                userbd.STATUS = true;
                userbd.USUARIO_ALTERACAO = User.Identity.Name;
                userbd.DATA_ALTERACAO = DateTime.Now;
                await _gestor.Update(userbd);
                return Accepted();
            }

        }

        [HttpPost("AdicionarGestor")]
        public async Task<IActionResult> AdicionarGestor([FromBody] int idUsuario)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var IdSetor = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.GroupSid).Value);

            var usuarioGestorView = new UsuarioGestor()
            {
                ID_SETOR = IdSetor,
                ID_USUARIO = idUsuario

            };
            return await Adicionar(usuarioGestorView);

        }

        [HttpPut("Desativar")]
        public async Task<IActionResult> Desativar(int id, [FromBody] UsuarioGestor usuarioGestorView)
        {

            var claims = (ClaimsIdentity)User.Identity;
            usuarioGestorView.USUARIO_ALTERACAO = User.Identity.Name;
            usuarioGestorView.DATA_ALTERACAO = DateTime.Now;

            if (id != usuarioGestorView.ID)
            {
                return Conflict();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _gestor.Update(usuarioGestorView);

                    return Accepted();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GestorExists(usuarioGestorView.ID))
                    {
                        return NotFound();
                    }
                }
            }
            return UnprocessableEntity();
        }
        private bool GestorExists(int id)
        {
            return _gestor.SelectId(id) != null;
        }
    }
}
