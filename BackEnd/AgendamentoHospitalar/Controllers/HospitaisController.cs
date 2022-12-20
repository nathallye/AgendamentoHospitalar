using AgendamentoHospitalar.Dto.Beneficiario;
using AgendamentoHospitalar.Dto.Hospital;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitaisController : Controller
    {
        public readonly IHospitalRepository _hospitalRepository;

        public HospitaisController(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        [HttpGet]
        [Route("ListarTodos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Hospital>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarTodos()
        {
            try
            {
                List<HospitalDto> lista = _hospitalRepository.ListarTodos();
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Hospital))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarPorId(int id)
        {
            if (id < 1)
                return NoContent();

            try
            {
                HospitalDto hospital = _hospitalRepository.ListarPorId(id);

                if (hospital == null)
                    return NoContent();

                return Ok(hospital);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Criar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Hospital))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Criar(HospitalCriarDto novoHospital)
        {
            try
            {
                Hospital hospitalEntidade = _hospitalRepository.Criar(novoHospital);

                return Ok(hospitalEntidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
