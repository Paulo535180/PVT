using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioController(IUsuarioRepository usuario)
        {
            usuarioRepository = usuario;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>Listagem()
        {
            return Ok(await usuarioRepository.Listagem());
        }
    }
}
