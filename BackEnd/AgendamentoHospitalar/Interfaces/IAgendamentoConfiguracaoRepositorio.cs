using AgendamentoHospitalar.DTO;

namespace AgendamentoHospitalar.Interfaces
{
    public interface IAgendamentoConfiguracaoRepositorio
    {
        List<AgendamentoConfiguracaoDTO> ListarTodos();
        AgendamentoConfiguracaoDTO PorId(int id);
        int Inserir(AgendamentoConfiguracaoDTO cadastrarDto);
        int Atualizar(AgendamentoConfiguracaoDTO cadastrarDto);
        int Excluir(int Id);
    }
}
