using AgendamentoHospitalar.Dto.Beneficiario;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiariosController : Controller
    {

        private readonly IBeneficiarioRepository _beneficiarioRepository;

        public BeneficiariosController(IBeneficiarioRepository beneficiarioRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
        }

        // GET localhost:7275/api/Benficiarios/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Beneficiario>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarTodos()
        {
            try
            {
                List<BeneficiarioDto> lista = _beneficiarioRepository.ListarTodos();
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

        // GET localhost:7275/api/Benficiarios/ListarPorId?id={}
        [HttpGet]
        [Route("ListarPorId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Beneficiario))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarPorId(int id)
        {
            if (id < 1)
                return NoContent();

            try
            {
                BeneficiarioDto beneficiario = _beneficiarioRepository.ListarPorId(id);

                if (beneficiario == null)
                    return NoContent();

                return Ok(beneficiario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST localhost:7275/api/Benficiarios/Criar
        [HttpPost]
        [Route("Criar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Beneficiario))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Criar(BeneficiarioCriarDto novoBeneficiario)
        {
            try
            {
                Beneficiario beneficiarioEntidade = _beneficiarioRepository.Criar(novoBeneficiario);

                return Ok(beneficiarioEntidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH localhost:7275/api/Benficiarios/Update?id={}
        [HttpPatch]
        [Route("Atualizar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Beneficiario))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Atualizar(BeneficiarioAtualizarDto beneficiario)
        {
            try
            {
               Beneficiario beneficiarioEntidade = _beneficiarioRepository.Atualizar(beneficiario);

                return Ok(beneficiarioEntidade);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE localhost:7153/api/People/Delete?id={}
        [HttpDelete]
        [Route("Excluir/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Excluir(int id)
        {
            try
            {
                int linhasRetornadas = _beneficiarioRepository.Excluir(id);
                return Ok(linhasRetornadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
