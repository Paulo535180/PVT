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
    [Route("Disciplina")]
    [Authorize]
    public class DisciplinaController : Controller
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaController(IDisciplinaRepository disciplina)
        {
            _disciplinaRepository = disciplina;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Listagem/{idCurso:int}")]
        public async Task<IActionResult> Listagem(int idCurso)
        {
            return Ok(await _disciplinaRepository.Listagem(idCurso));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> SelectID(int Id)
        {
            return Ok(await _disciplinaRepository.SelectId(Id));
        }

        [HttpPost("")]
        public async Task<IActionResult> Inserir([FromBody] Disciplina disciplina)
        {
            var claims = (ClaimsIdentity)User.Identity;
            disciplina.USUARIO_CRIACAO = User.Identity.Name;
            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 422, view está invalida de acordo com o Modelo

            await _disciplinaRepository.Insert(disciplina);

            return StatusCode(201); //--> 201
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int Id, [FromBody] Disciplina disciplina)
        {

            if (Id != disciplina.ID)
                return Conflict(); //--> erro 409, ID diferente do Corpo

            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 409, view está invalida de acordo com o Modelo


            disciplina.USUARIO_ALTERACAO = User.Identity.Name;
            disciplina.DATA_ALTERACAO = DateTime.Now;
            await _disciplinaRepository.Update(disciplina);

            return StatusCode(202); //--> 202 aceito
        }

        [HttpPatch("{Id:int}/AlterarStatus")]
        public async Task<IActionResult> AlterarStatus(int Id)
        {
            var disciplina = await _disciplinaRepository.SelectId(Id);

            disciplina.STATUS = !disciplina.STATUS;

            await _disciplinaRepository.Update(disciplina);

            return StatusCode(202); //--> 202 aceito
        }


    }
}
