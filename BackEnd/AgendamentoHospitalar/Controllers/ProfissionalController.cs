
using AgendamentoHospitalar.Dto.Profissional;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalController : Controller
    {

        private readonly IProfissionalRepository _profissionalRepository;

        public ProfissionalController(IProfissionalRepository profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }


        [HttpGet]
        [Route("ListarTodos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Profissional>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarTodos()
        {
            try
            {
                List<ProfissionalDto> lista = _profissionalRepository.ListarTodos();
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

        //Criar
        [HttpPost]
        [Route("Criar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Profissional))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Criar(ProfissionalCriarDto novoProfissional)
        {
            try
            {
                Profissional profissionalEntidade = _profissionalRepository.Criar(novoProfissional);

                return Ok(profissionalEntidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //atualizar
        [HttpPatch]
        [Route("Atualizar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Profissional))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(ProfissionalAtualizarDto profissional)
        {
            try
            {
                Profissional profissionalEntidade = _profissionalRepository.Atualizar(profissional);

                return Ok(profissionalEntidade);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Delete
        [HttpDelete]
        [Route("Excluir/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Excluir(int id)
        {
            try
            {
                int linhasRetornadas = _profissionalRepository.Excluir(id);
                return Ok(linhasRetornadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
