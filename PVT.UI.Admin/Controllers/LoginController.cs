using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
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

           
            return View();
        }

        [HttpPost]
      
        public async Task<IActionResult> Login(Usuario modelo)
        {
           

            if (!ModelState.IsValid)
            {
                return Redirect("/Login/Index?persist=true");
            }
            var user = await usuarioRepository.ValidarLogin(modelo);
            if (user == null)
            {
                return Redirect("/Login/Index?usuarioInexistente=true");
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.PrimarySid, modelo.ID.ToString()),
                new Claim(ClaimTypes.Actor, modelo.Login),
                new Claim(ClaimTypes.Role, modelo.Perfil),
                new Claim(ClaimTypes.Name, modelo.Nome),
                new Claim(ClaimTypes.Email, modelo.Email),

            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, "cookie");

            ClaimsPrincipal principalClaim = new ClaimsPrincipal(identity);

            var cookie = new AuthenticationProperties()
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync
                (
                scheme: CookieAuthenticationDefaults.AuthenticationScheme,
                principalClaim,
                properties: cookie
                );

            return Redirect("Home/Index");
        }
    }
}
