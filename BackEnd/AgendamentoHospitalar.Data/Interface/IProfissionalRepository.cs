using AgendamentoHospitalar.Dto.Profissional;
using AgendamentoHospitalar.Entidade;

namespace AgendamentoHospitalar.Interface
{
    public interface IProfissionalRepository
    {
        List<ProfissionalDto> ListarTodos();
        ProfissionalDto ListarPorId(int id);
        Profissional Criar(ProfissionalCriarDto profissional);
        Profissional Atualizar(ProfissionalAtualizarDto profissional);
        int Excluir(int Id);
    }
}
