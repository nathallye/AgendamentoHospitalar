using AgendamentoHospitalar.Interface;
using AgendamentoHospitalarData.DTO.Especialidade;
using Microsoft.AspNetCore.Mvc;


namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        public readonly IEspecialidadeRepositorio _repo;

        public EspecialidadeController( IEspecialidadeRepositorio repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("/CadastrarEspecialidade")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InserirEspecialidade(EspecialidadeDTO novaEspecialidade)
        {
            try
            {
                _repo.Inserir(novaEspecialidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("/ListarEspecialidades")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<EspecialidadeDTO>))]
        public IActionResult ListarTodas()
        {
            try
            {
                var listaEspecialidade = _repo.ListarTodas();
                if (listaEspecialidade == null)
                {
                    return NoContent();
                }

                if (listaEspecialidade.Count == 0)
                {
                    throw new Exception("Sem elementos");
                }

                return Ok(listaEspecialidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("/ListarEspecialidades/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EspecialidadeDTO))]
        public IActionResult ListarPorId(int id)
        {
            try
            {
                var especialidade = _repo.PorId(id);
                if (especialidade == null)
                {
                    return NoContent();
                }

                return Ok(especialidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("/DeletarEspecialidade/{id}")]
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
        [Route("/AtualizarEspecialidade")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AtualizarEspecialidade(EspecialidadeDTO novaEspecialidade)
        {
            try
            {
                var linhasAfetadas = _repo.Atualizar(novaEspecialidade);
                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}