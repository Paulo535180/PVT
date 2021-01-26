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
    [Route("Gestor")]
    [Authorize]
    public class GestorController : Controller
    {
        private readonly IUsuarioGestorRepository _context;
        public GestorController(IUsuarioGestorRepository context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Listagem")]
        public async Task<IActionResult> Listagem()
        {
            return Ok(await _context.ListagemGestores());
        }

        [HttpGet("Listagem/{idSetor:int}")]
        public async Task<IActionResult> ListagemPorSetor(int idSetor)
        {

            return Ok(await _context.ListagemGestoresPorSetor(idSetor));
        }

        [HttpPost("Adcionar")]
        public async Task<IActionResult> Adcionar([FromBody] UsuarioGestor usuarioGestor)
        {

            var userbd = _context.Select(usuarioGestor);
            if (userbd == null)
                userbd = new UsuarioGestor();

            var claims = (ClaimsIdentity)User.Identity;
            usuarioGestor.USUARIO_CRIACAO = User.Identity.Name;
            usuarioGestor.DATA_CRIACAO = DateTime.Now;
            


            if (ModelState.IsValid)
            {
                return View(usuarioGestor);
            }
            await _context.Insert(usuarioGestor);
            return Accepted();
        }

        //[HttpGet("Vincular")]
        //public async Task<IActionResult> VincularGestor([FromQuery] int ID)
        //{

        //    var claims = (ClaimsIdentity)User.Identity;

        //    //usuarioGestor.USUARIO_CRIACAO = User.Identity.Name;
        //    //usuarioGestor.DATA_CRIACAO = DateTime.Now;



        //    //if (ModelState.IsValid)
        //    //{
        //    //    return View(usuarioGestor);
        //    //}
        //    //await _context.Insert(usuarioGestor);
        //    return Accepted();
        //}

    }
}
