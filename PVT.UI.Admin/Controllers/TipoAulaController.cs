using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Route("TipoAula")]
    [Authorize]
    public class TipoAulaController : Controller
    {
        private readonly ITipoAulaRepository _tipoAula;

        public TipoAulaController(ITipoAulaRepository tipoAula)
        {
            _tipoAula = tipoAula;
        }

        [HttpGet("Listagem")]
        public async Task<IActionResult> ListagemTipoAula()
        {
            return Ok(await _tipoAula.ListagemTipoAula());
        }
    }
}
