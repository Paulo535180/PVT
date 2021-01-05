using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.Controllers
{
    public class LoginController : Controller
    {

        private IUsuarioRepository usuarioList;

        public LoginController(IUsuarioRepository context)
        {
            usuarioList = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await usuarioList.Listagem());

        }
    }
}
