using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PVT.UI.Admin.Controllers
{
    [Route("Curso")]
    [Authorize]
    public class CursoController : Controller
    {

        private readonly ICursoRepository _cursorepository;

        public CursoController(ICursoRepository curso)
        {
            _cursorepository = curso;
        }

        /// <summary>
        /// Rota: Curso
        /// Metodo GET
        /// Tela
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Rota: Curso/Listagem
        /// Metodo GET
        /// Lista de Curso
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("Listagem")]
        public async Task<IActionResult> Listagem()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var gestor =  Convert.ToInt32(claims.Claims.ToList().Find(id => id.Type == ClaimTypes.PrimaryGroupSid).Value);
            return Ok(await _cursorepository.Listagem(gestor));
        }

        /// <summary>
        /// Rota: Curso/(id do Resgistro)
        /// Metodo GET
        /// registro do curso selecionado
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> SelectID(int Id)
        {
            return Ok(await _cursorepository.SelectId(Id));
        }

        /// <summary>
        /// Rota: Curso
        /// Metodo POST
        /// Inserir um novo curso
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<IActionResult> Inserir([FromBody] Curso curso)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 422, view está invalida de acordo com o Modelo

            await _cursorepository.Insert(curso);

            return StatusCode(201); //--> 201
        }

        /// <summary>
        /// Rota: Curso
        /// Metodo PUT
        /// Alterar unm novo curso
        /// </summary>

        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int Id, [FromBody] Curso curso)
        {
            if (Id != curso.ID)
                return Conflict(); //--> erro 409, ID diferente do Corpo

            if (!ModelState.IsValid)
                return UnprocessableEntity(); //--> erro 409, view está invalida de acordo com o Modelo

            await _cursorepository.Update(curso);

            return StatusCode(202); //--> 202 aceito
        }


        /// <summary>
        /// Rota: Curso/(ID)/AlterarStatus
        /// Metodo Patch
        /// Atualizar Status
        /// </summary>
        /// <returns></returns>
        [HttpPatch("{Id:int}/AlterarStatus")]
        public async Task<IActionResult> AlterarStatus(int Id)
        {
            var curso = await _cursorepository.SelectId(Id);

            curso.STATUS = !curso.STATUS;

            await _cursorepository.Update(curso);

            return StatusCode(202); //--> 202 aceito
        }
    }
}