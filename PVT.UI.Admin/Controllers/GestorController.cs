using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Authorize]
    public class GestorController : Controller
    {


        private readonly IUsuarioGestorRepository _context;
        public GestorController(IUsuarioGestorRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Listagem()
        {
            return Ok(await _context.ListagemGestores());
        }

        [HttpGet("Listagem/{idSetor:int}")]
        public async Task<IActionResult> ListagemPorSetor(int idSetor)
        {
            
            return Ok(await _context.ListagemGestoresPorSetor(idSetor));
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarGestor([FromBody] UsuarioGestor usuarioGestor)
        {
            var claims = (ClaimsIdentity)User.Identity;
            usuarioGestor.USUARIO_CRIACAO = User.Identity.Name;
            usuarioGestor.ID_USUARIO_GESTOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            usuarioGestor.DATA_CRIACAO = DateTime.Now;
            if (ModelState.IsValid) return View(usuarioGestor);
            await _context.Insert(usuarioGestor);
            return Created("/Gestor/Index", usuarioGestor);
        }

    }
}
