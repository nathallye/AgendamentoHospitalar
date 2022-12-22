using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Entidade;

namespace AgendamentoHospitalar.Interface
{
    public interface IAgendamentoRepository
    {
        List<AgendamentoOutDTO> ListarTodos();
        AgendamentoDto ListarPorId(int id);
        Agendamento Criar(AgendamentoDto agendamento);
        Agendamento Atualizar(AgendamentoAtualizarDto agendamento);
        int Excluir(int id);
    }
}
