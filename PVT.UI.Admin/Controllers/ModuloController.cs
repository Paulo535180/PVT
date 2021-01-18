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
        private readonly IModuloRepository _context;
        public ModuloController(IModuloRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Listagem()
        {
            return Ok(await _context.ListagemModulos());
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarModulo([FromBody] Modulo modulo)
        {
            var claims = (ClaimsIdentity)User.Identity;
            modulo.USUARIO_CRIACAO = User.Identity.Name;
            modulo.ID_USUARIO_GESTOR = Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            modulo.DATA_CRIACAO = DateTime.Now;
            if (ModelState.IsValid) return View(modulo);
            await _context.Insert(modulo);
            return Created("/Modulo/Index", modulo);
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
                    await _context.Update(modulo);

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
        private bool ModuloExists(int id)
        {
            return _context.SelectId(id) != null;
        }
    }
}
