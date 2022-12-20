using AgendamentoHospitalar.Dto.Hospital;
using AgendamentoHospitalar.Entidade;
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

        public HospitalDto ListarPorId(int id)
        {
            return (from t in _context.Hospitais
                    where t.IdHospital == id
                    select new HospitalDto()
                    {
                        IdHospital = t.IdHospital,
                        Nome = t.Nome,
                        Cnpj = t.Cnpj,
                        Telefone = t.Telefone,
                        Endereco = t.Endereço,
                        Cnes = t.Cnes,
                        Ativo = t.Ativo
                    })
                    ?.FirstOrDefault()
                    ?? new HospitalDto();
        }

        public Hospital Criar(HospitalCriarDto hospital)
        {
            Hospital hospitalEntidade = new Hospital()
            {
                Nome = hospital.Nome,
                Cnpj = hospital.Cnpj,
                Telefone = hospital.Telefone,
                Endereço = hospital.Endereço,
                Cnes = hospital.Cnes,
                Ativo = hospital.Ativo
            };

            _context.ChangeTracker.Clear();
            _context.Hospitais.Add(hospitalEntidade);
            _context.SaveChanges();
            return hospitalEntidade;
        }

    }
}
