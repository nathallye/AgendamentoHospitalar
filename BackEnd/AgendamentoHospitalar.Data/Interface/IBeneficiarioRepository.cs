using AgendamentoHospitalar.Dto.Beneficiario;
using AgendamentoHospitalar.Entidade;
using System;

namespace AgendamentoHospitalar.Interface
{
    public interface IBeneficiarioRepository
    {
        List<BeneficiarioDto> ListarTodos();
        BeneficiarioDto ListarPorId(int id);
        Beneficiario Criar(BeneficiarioCriarDto beneficiario);
        Beneficiario Atualizar(BeneficiarioAtualizarDto beneficiario);
        int Excluir(int Id);
    }
}
