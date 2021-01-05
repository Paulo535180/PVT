using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Controllers
{
    public class SetoresController : Controller
    {
        private readonly ISetorRepository _context;

        public SetoresController(ISetorRepository context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SelectAll());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.SelectId(id.Value);
            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        public IActionResult Create()
        {
            return View(new Setor());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] Setor setor)
        {

            if (ModelState.IsValid)
            {
                await _context.Insert(setor);
                await _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(setor);
        }

        // GET: Setores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.SelectId(id.Value);
            if (setor == null)
            {
                return NotFound();
            }
            return View(setor);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NOME,DESCRICAO,ID,DATA_CRIACAO,USUARIO_CRIACAO,DATA_ALTERACAO,USUARIO_ALTERACAO,STATUS")] Setor setor)
        {
            if (id != setor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await _context.Update(setor);
                    await _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetorExists(setor.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(setor);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.SelectId(id.Value);
            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setor = await _context.SelectId(id);
            await _context.Delete(id) ;
            await _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool SetorExists(int id)
        {
            return _context.SelectId(id) != null;
        }
    }
}
