using AgendamentoHospitalar.Dto.Beneficiario;
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
                Endereco = s.Endereco,
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
                        Endereco = t.Endereco,
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
                Endereco = hospital.Endereco,
                Cnes = hospital.Cnes,
                Ativo = hospital.Ativo
            };

            _context.ChangeTracker.Clear();
            _context.Hospitais.Add(hospitalEntidade);
            _context.SaveChanges();
            return hospitalEntidade;
        }

        public Hospital Atualizar(HospitalAtualizarDto hospital)
        {
            Hospital hospitalEntidadeBD =
                (from c in _context.Hospitais
                 where c.IdHospital == hospital.IdHospital
                 select c)
                 ?.FirstOrDefault()
                 ?? new Hospital();

            if (hospitalEntidadeBD == null || DBNull.Value.Equals(hospitalEntidadeBD.IdHospital) || hospitalEntidadeBD.IdHospital == 0)
            {
                return null;
            }

            Hospital hospitalEntidade = new Hospital()
            {
                IdHospital = hospital.IdHospital,
                Nome = (hospital.Nome != null ? hospital.Nome : hospitalEntidadeBD.Nome),
                Cnpj = (hospital.Cnpj != null ? hospital.Cnpj : hospitalEntidadeBD.Cnpj),
                Telefone = (hospital.Telefone != null ? hospital.Telefone : hospitalEntidadeBD.Telefone),
                Endereco = (hospital.Endereco != null ? hospital.Endereco : hospitalEntidadeBD.Endereco),
                Cnes = (hospital.Cnes != null ? hospital.Cnes : hospitalEntidadeBD.Cnes),
                Ativo = hospital.Ativo
            };

            _context.ChangeTracker.Clear();
            _context.Hospitais.Update(hospitalEntidade);
            _context.SaveChanges();
            return hospitalEntidade;
        }

        public int Excluir(int id)
        {
            var hospital = new Hospital()
            {
                IdHospital = id
            };

            _context.Hospitais.Remove(hospital);
            return _context.SaveChanges();
        }
    }
}
