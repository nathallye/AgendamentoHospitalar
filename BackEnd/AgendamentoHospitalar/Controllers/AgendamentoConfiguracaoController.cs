using AgendamentoHospitalar.DTO.AgendamentoConfig;
using AgendamentoHospitalar.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoConfiguracaoController : ControllerBase
    {
        private IAgendamentoConfiguracaoRepositorio _repo { get; set; }

        public AgendamentoConfiguracaoController(IAgendamentoConfiguracaoRepositorio repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("/CadastrarAgendamentoConfiguracao")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InserirEspecialidade(AgendamentoConfiguracaoDTO novoAgendamentoConfig)
        {
            try
            {
                _repo.Inserir(novoAgendamentoConfig);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/ListarAgendamentoConfiguracao")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public IActionResult ListarTodas()
        {
            try
            {
                var listaAgendamentoConfig = _repo.ListarTodos();
                if (listaAgendamentoConfig == null)
                {
                    return NoContent();
                }

                if (listaAgendamentoConfig.Count == 0)
                {
                    throw new Exception("Sem elementos");
                }

                return Ok(listaAgendamentoConfig);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
   

        [HttpDelete]
        [Route("/DeletarAgendamentoConfiguracao/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Excluir(int id)
        {
            try
            {
                var linhasAfetadas = _repo.Excluir(id);

                if (linhasAfetadas < 1)
                    return NoContent();

                return Ok(linhasAfetadas);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }

        }

        [HttpPost]
        [Route("/AtualizarAgendamentoConfiguracao")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AtualizarEspecialidade(AgendamentoConfiguracaoDTO atualizacaodto)
        {
            try
            {
                _repo.Atualizar(atualizacaodto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/ListarAgendamentoConfiguracao/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public IActionResult ListarJoin(int id)
        {
            try
            {
                var agendamentoconfig = _repo.ListarJoin(id);
                if (agendamentoconfig == null)
                {
                    return NoContent();
                }

                return Ok(agendamentoconfig);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
