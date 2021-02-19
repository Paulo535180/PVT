using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Route("Aula")]
    [Authorize]
    public class AulaController : Controller
    {
        private readonly IAulaRepository _aulaRepositoryy;

        public AulaController(IAulaRepository aula)
        {
            _aulaRepositoryy = aula;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Listagem/{idCurso:int}")]
        public async Task<IActionResult> Listagem(int idCurso)
        {
            return Ok(await _aulaRepositoryy.Listagem(idCurso));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> SelectID(int Id)
        {
            return Ok(await _aulaRepositoryy.SelectId(Id));
        }

        [HttpPost("")]
        public async Task<IActionResult> Inserir([FromBody] Aula aula)
        {
            var claims = (ClaimsIdentity)User.Identity;
            aula.USUARIO_CRIACAO = User.Identity.Name;
            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 422, view está invalida de acordo com o Modelo

            await _aulaRepositoryy.Insert(aula);

            return StatusCode(201); //--> 201
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int Id, [FromBody] Aula aula)
        {

            if (Id != aula.ID)
                return Conflict(); //--> erro 409, ID diferente do Corpo

            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 409, view está invalida de acordo com o Modelo


            aula.USUARIO_ALTERACAO = User.Identity.Name;
            aula.DATA_ALTERACAO = DateTime.Now;
            await _aulaRepositoryy.Update(aula);

            return StatusCode(202); //--> 202 aceito
        }

        [HttpPatch("{Id:int}/AlterarStatus")]
        public async Task<IActionResult> AlterarStatus(int Id)
        {
            var aula = await _aulaRepositoryy.SelectId(Id);

            aula.STATUS = !aula.STATUS;

            await _aulaRepositoryy.Update(aula);

            return StatusCode(202); //--> 202 aceito
        }
    }
}
