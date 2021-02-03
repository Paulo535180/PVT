using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Authorize]
    public class SetorController : Controller
    {
        private readonly ISetorRepository _context;
        public SetorController(ISetorRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Listagem()
        {
            return Ok(await _context.SelectAll());
        }


        public async Task<IActionResult> ListagemPorSetor(Setor setor)
        {

            return Ok(await _context.ListagemSetorPorId(setor));
        }
        
        [HttpPost]
        public async Task<IActionResult> AdicionarSetor([FromBody] Setor setor)
        {
            setor.USUARIO_CRIACAO = User.Identity.Name;

            setor.DATA_CRIACAO = DateTime.Now;

            if (ModelState.IsValid) return View(setor);

            await _context.Insert(setor);
            return Created("/Setor/Index", setor);
        }

        [HttpPut]
        public async Task<IActionResult> EditarSetor(int id,[FromBody] Setor setor)
        {
            setor.USUARIO_ALTERACAO = User.Identity.Name;
            setor.DATA_ALTERACAO = DateTime.Now;

            if (id != setor.ID)
            {
                return Conflict();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Update(setor);
                    
                    return Accepted();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetorExists(setor.ID))
                    {
                        return NotFound();
                    }
                }
            }
            return UnprocessableEntity();
        }
        private bool SetorExists(int id)
        {
            return _context.SelectId(id) != null;
        }
    }
}
