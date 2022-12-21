using AgendamentoHospitalar.DTO.AgendamentoConfig;

namespace AgendamentoHospitalar.Interface
{
    public interface IAgendamentoConfiguracaoRepositorio
    {
        List<AgendamentoConfigOutputDTO> ListarTodos();
        AgendamentoConfiguracaoDTO PorId(int id);
        AgendamentoConfigOutputDTO ListarJoin(int id);
        int Inserir(AgendamentoConfiguracaoDTO cadastrarDto);
        int Atualizar(AgendamentoConfiguracaoDTO cadastrarDto);
        int Excluir(int Id);
    }
}
