using AgendamentoHospitalar.Dto.Agendamento;

namespace AgendamentoHospitalar.Interface
{
    public interface IAgendamentoRepository
    {
        List<AgendamentoDto> ListarTodos();
    }
}
