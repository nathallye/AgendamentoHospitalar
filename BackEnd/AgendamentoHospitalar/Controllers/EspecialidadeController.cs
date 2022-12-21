using AgendamentoHospitalar.DTO;
using AgendamentoHospitalar.Modelos;
using AgendamentoHospitalar.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private EspecialidadeRepositorio _repo { get; set; }

        public EspecialidadeController()
        {
            _repo = new EspecialidadeRepositorio();
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
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
                _repo.Atualizar(novaEspecialidade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}