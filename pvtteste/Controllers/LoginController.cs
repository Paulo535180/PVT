using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVT.Domain.Models;

namespace pvtteste.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View( new Usuario { });
        }



        [HttpPost]
        public async Task<IActionResult> Login(Usuario modelo)
        {
            var x = modelo;

            return RedirectToAction("Index", "Home");
        }



    }
}
