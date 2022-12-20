using AgendamentoHospitalar.Dto.Hospital;

namespace AgendamentoHospitalar.Interface
{
    public interface IHospitalRepository
    {
        List<HospitalDto> ListarTodos();
    }
}
