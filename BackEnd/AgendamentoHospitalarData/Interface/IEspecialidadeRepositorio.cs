using AgendamentoHospitalar.DTO;

namespace AgendamentoHospitalar.Interface
{
    public interface IEspecialidadeRepositorio
    {
        List<EspecialidadeDTO> ListarTodas();

        EspecialidadeDTO PorId(int id);

        int Inserir(EspecialidadeDTO cadastrarDto);

        int Atualizar(EspecialidadeDTO cadastrarDto);

        int Excluir(int Id);

    }
}
