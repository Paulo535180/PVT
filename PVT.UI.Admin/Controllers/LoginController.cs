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
                return Redirect("/Login/Index?persist=true");
            }

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.PrimarySid, user.ID.ToString()));
            claims.Add(new Claim(ClaimTypes.Actor, user.Login));
            claims.Add(new Claim(ClaimTypes.Role, user.Perfil));
            claims.Add(new Claim(ClaimTypes.Name, user.Nome));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
                

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

            return Redirect("/");
        }
    }
}
