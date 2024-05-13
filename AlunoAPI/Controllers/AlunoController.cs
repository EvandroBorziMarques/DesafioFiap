using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Dominio.Entidades;
using Dominio.DTO;
using Dominio.Interfaces;

namespace AlunoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAluno _aluno;


        public AlunoController(IMapper mapper, IAluno aluno)
        {
            _mapper = mapper;
            _aluno = aluno;
        }

        /// <summary>
        /// Cadastra alunos
        /// </summary>
        /// <returns></returns>
        [HttpPost("create")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AlunoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AlunoDTO> AlunoCreate([FromBody] AlunoDTO alunoDTO)
        {
            try
            {
                bool response = _aluno.AlunoCreate(alunoDTO);
                return response ? Created(string.Empty, "Aluno criado com sucesso") : BadRequest("Registro não criado!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }


        /// <summary>
        /// Recupera lista de alunos
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AlunoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AlunoDTO> AlunoList()
        {
            try
            {
                List<Aluno> aluno = _aluno.AlunoList();
                return Ok(_mapper.Map<List<Aluno>>(aluno));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }

        /// <summary>
        /// Recupera um aluno pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AlunoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AlunoDTO> AlunoGetById(int id)
        {
            try
            {
                Aluno aluno = _aluno.AlunoGetById(id);
                return Ok(_mapper.Map<AlunoDTO>(aluno));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }
        
        /// <summary>
        /// Atualiza as informações do aluno
        /// </summary>
        /// <param name="aluno"></param>
        /// <returns></returns>
        [HttpPut("update")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Aluno), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AlunoDTO> AlunoUpdate([FromBody] Aluno aluno)
        {
            try
            {
                bool response = _aluno.AlunoUpdate(aluno);

                return response ? Ok("Registro atualizado com sucesso!") : BadRequest("Registro não encontrado") ;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }


        /// <summary>
        /// Deleta as informações do aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="alunoDTO"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<bool> AlunoDelete(int id)
        {
            try
            {
                bool response = _aluno.AlunoDelete(id);
                return response ? Ok("Registro deletado com sucesso!") : BadRequest("Registro não deletado.");              
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao processar sua solicitação. {ex.Message}");
            }
        }
    }
}
