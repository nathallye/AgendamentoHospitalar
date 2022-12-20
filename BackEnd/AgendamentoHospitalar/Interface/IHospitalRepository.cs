using AgendamentoHospitalar.Dto.Hospital;
using AgendamentoHospitalar.Entidade;

namespace AgendamentoHospitalar.Interface
{
    public interface IHospitalRepository
    {
        List<HospitalDto> ListarTodos();
        HospitalDto ListarPorId(int id);
        Hospital Criar(HospitalCriarDto hospital);
    }
}
