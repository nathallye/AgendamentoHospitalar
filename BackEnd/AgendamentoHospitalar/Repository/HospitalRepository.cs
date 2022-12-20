using AgendamentoHospitalar.Dto.Beneficiario;
using AgendamentoHospitalar.Dto.Hospital;
using AgendamentoHospitalar.Interface;
using AgendamentoHospitalar.Repository.Context;

namespace AgendamentoHospitalar.Repository
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly DatabaseContext _context;

        public HospitalRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<HospitalDto> ListarTodos()
        {
            return _context.Hospitais.Select(s => new HospitalDto()
            {
                IdHospital = s.IdHospital,
                Nome = s.Nome,
                Cnpj = s.Cnpj,
                Telefone = s.Telefone,
                Endereco = s.Endereço,
                Cnes = s.Cnes,
                Ativo = s.Ativo
            }).ToList();
        }
    }
}
