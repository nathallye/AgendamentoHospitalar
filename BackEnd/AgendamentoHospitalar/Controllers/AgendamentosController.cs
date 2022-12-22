using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentosController : Controller
    {
        private readonly IAgendamentoRepository _agendamentoRepository;

        public AgendamentosController(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        [HttpGet]
        [Route("ListarTodos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Agendamento>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarTodos()
        {
            try
            {
                List<AgendamentoOutDTO> lista = _agendamentoRepository.ListarTodos();
                if (lista == null)
                {
                    return NoContent();
                }

                if (lista.Count == 0)
                {
                    throw new Exception("Sem elementos");
                }

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListarPorId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Agendamento))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarPorId(int id)
        {
            if (id < 1)
                return NoContent();

            try
            {
                AgendamentoDto agendamento = _agendamentoRepository.ListarPorId(id);

                if (agendamento == null)
                    return NoContent();

                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Criar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Agendamento))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Criar(AgendamentoDto novoAgendamento)
        {
            try
            {
                Agendamento agendamentoEntidade = _agendamentoRepository.Criar(novoAgendamento);

                return Ok(agendamentoEntidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("Atualizar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Agendamento))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Atualizar(AgendamentoAtualizarDto agendamento)
        {
            try
            {
                Agendamento agendamentoEntidade = _agendamentoRepository.Atualizar(agendamento);

                return Ok(agendamentoEntidade);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("Excluir/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Excluir(int id)
        {
            try
            {
                int linhasRetornadas = _agendamentoRepository.Excluir(id);
                return Ok(linhasRetornadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
