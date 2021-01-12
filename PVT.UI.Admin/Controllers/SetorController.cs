using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
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
    }
}
