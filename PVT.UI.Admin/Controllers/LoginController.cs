using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;
        public LoginController(IUsuarioRepository usuario)
        {
            usuarioRepository = usuario;
        }

        public IActionResult Index()
        {
            return View(new Usuario());
        }

        public async Task<IActionResult> Login(Usuario modelo)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Login/Index?persist=true");
            }
            var user = await usuarioRepository.ValidarLogin(modelo);
            if(user == null)
            {
                return Redirect("usuarioInexistente=true");
            }

            return Redirect("Home/Index");
        }
    }
}
