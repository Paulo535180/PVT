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
        private readonly IUsuarioGestorRepository _context;
        private readonly IUsuarioRepository _usuarioRepository;
        public GestorController(IUsuarioGestorRepository context, IUsuarioRepository usuarioRepository)
        {
            _context = context;
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

            return Ok(await _context.ListagemGestoresPorSetor(idSetor));
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] UsuarioGestor usuarioGestorView)
        {

            var claims = (ClaimsIdentity)User.Identity;
            var userbd = await _context.ObterUsuarioGestor(usuarioGestorView);
            if (userbd == null)
            {
                usuarioGestorView.USUARIO_CRIACAO = User.Identity.Name;
                usuarioGestorView.DATA_CRIACAO = DateTime.Now;
                usuarioGestorView.STATUS = true;
                if (ModelState.IsValid)
                {
                    return View(usuarioGestorView);
                }
                await _context.Insert(usuarioGestorView);
                return Accepted();
            }
            else
            {
                userbd.STATUS = true;
                userbd.USUARIO_ALTERACAO = User.Identity.Name;
                userbd.DATA_ALTERACAO = DateTime.Now;
                await _context.Update(userbd);
                return Accepted();
            }

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
                    await _context.Update(usuarioGestorView);

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
            return _context.SelectId(id) != null;
        }
    }
}
