using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Entidade;

namespace AgendamentoHospitalar.Interface
{
    public interface IAgendamentoRepository
    {
        List<AgendamentoDto> ListarTodos();
        AgendamentoDto ListarPorId(int id);
        Agendamento Criar(AgendamentoCriarDto agendamento);
        Agendamento Atualizar(AgendamentoAtualizarDto agendamento);
        int Excluir(int id);
    }
}
