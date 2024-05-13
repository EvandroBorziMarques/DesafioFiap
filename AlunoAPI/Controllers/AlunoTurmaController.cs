using AutoMapper;
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlunoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoTurmaController : ControllerBase
    {
        private readonly IAlunoTurma _alunoTurma;


        public AlunoTurmaController(IAlunoTurma alunoTurma)
        {
            _alunoTurma = alunoTurma;
        }

        /// <summary>
        /// Cadastra um aluno na turma
        /// </summary>
        /// <returns></returns>
        [HttpPost("create")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AlunoTurma), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AlunoTurma> AlunoTurmaCreate([FromBody] AlunoTurma alunoTurma)
        {
            try
            {
                bool response = _alunoTurma.AlunoTurmaCreate(alunoTurma);
                return response ? Created(string.Empty, "Aluno adicionado a Turma com sucesso") : BadRequest("Aluno não adicionado a Turma!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }

        /// <summary>
        /// Deleta aluno da turma
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpDelete("delete/{studentId}/{classId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<bool> AlunoTurmaDelete(int studentId, int classId)
        {
            try
            {
                bool response = _alunoTurma.AlunoTurmaDelete(studentId, classId);
                return response ? Ok("Aluno retirado da Turma com sucesso!") : BadRequest("Aluno não retirado da Turma!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }
    }
}
