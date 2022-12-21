using AgendamentoHospitalar.Dto.Agendamento;

namespace AgendamentoHospitalar.Interface
{
    public interface IAgendamentoRepository
    {
        List<AgendamentoDto> ListarTodos();
        AgendamentoDto ListarPorId(int id);
    }
}
