using AutoMapper;
using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlunoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITurma _turma;


        public TurmaController(IMapper mapper, ITurma turma)
        {
            _mapper = mapper;
            _turma = turma;
        }

        /// <summary>
        /// Cadastra turma
        /// </summary>
        /// <returns></returns>
        [HttpPost("create")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Turma), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<TurmaDTO> TurmaCreate([FromBody] Turma turma)
        {
            try
            {
                bool response = _turma.TurmaCreate(turma);
                return response ? Created(string.Empty, "Turma criada com sucesso") : BadRequest("Turma não criada!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }


        /// <summary>
        /// Recupera lista de turmas
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TurmaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<TurmaDTO> TurmaList()
        {
            try
            {
                List<Turma> turma = _turma.TurmaList();
                return Ok(_mapper.Map<List<TurmaDTO>>(turma));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }

        /// <summary>
        /// Recupera uma turma pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TurmaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<TurmaDTO> TurmaGetById(int id)
        {
            try
            {
                Turma turma = _turma.TurmaGetById(id);
                return Ok(_mapper.Map<TurmaDTO>(turma));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }

        /// <summary>
        /// Atualiza as informações do turma
        /// </summary>
        /// <param name="turma"></param>
        /// <returns></returns>
        [HttpPut("update")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Turma), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<TurmaDTO> TurmaUpdate([FromBody] Turma turma)
        {
            try
            {
                //Validação de payload
                //if (turmaDTO.ID != id)
                //    return BadRequest("Id diferentes");

                bool response = _turma.TurmaUpdate(turma);

                return response ? Ok("Registro atualizado com sucesso!") : BadRequest("Registro não encontrado");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }


        /// <summary>
        /// Deleta as informações da turma
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<bool> TurmaDelete(int id)
        {
            try
            {
                bool response = _turma.TurmaDelete(id);
                return response ? Ok("Registro deletado com sucesso!") : BadRequest("Registro não deletado.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }
    }
}
