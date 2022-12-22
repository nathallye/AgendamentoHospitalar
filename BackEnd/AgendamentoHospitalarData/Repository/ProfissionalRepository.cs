using AgendamentoHospitalar.Dto.Profissional;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using AgendamentoHospitalar.Repository.Context;

namespace AgendamentoHospitalar.Repository
{
public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly DatabaseContext _context;

        public ProfissionalRepository(DatabaseContext context)

        {
            _context = context;
        }

        public Profissional Atualizar(ProfissionalAtualizarDto profissional)
        {
            Profissional profissionalEntidadeBD =
               (from c in _context.Profissionais
                where c.IdProfissional == profissional.IdProfissional
                select c)
                ?.FirstOrDefault()
                ?? new Profissional();

            if (profissionalEntidadeBD == null || DBNull.Value.Equals(profissionalEntidadeBD.IdProfissional) || profissionalEntidadeBD.IdProfissional == 0)
            {
                return null;
            }

            Profissional profissionalEntidade = new Profissional()
            {

                IdProfissional = profissional.IdProfissional,
                Nome = (profissional.Nome != null ? profissional.Nome : profissionalEntidadeBD.Nome),
                Telefone = (profissional.Telefone != null ? profissional.Telefone : profissionalEntidadeBD.Telefone),
                Endereco = (profissional.Endereco != null ? profissional.Endereco : profissionalEntidadeBD.Endereco),
                Ativo = profissional.Ativo,

            };

            _context.ChangeTracker.Clear();
            _context.Profissionais.Update(profissionalEntidade);
            _context.SaveChanges();
            return profissionalEntidade;
        }

        public Profissional Criar(ProfissionalCriarDto profissional)
        {
            Profissional profissionalEntidade = new Profissional()
            {
                Nome = profissional.Nome,
                Telefone = profissional.Telefone,
                Endereco = profissional.Endereco,
                Ativo = profissional.Ativo,
            };

            _context.ChangeTracker.Clear();
            _context.Profissionais.Add(profissionalEntidade);
            _context.SaveChanges();
            return profissionalEntidade;
        }

        public int Excluir(int Id)
        {
            var profissional = new Profissional()
            {
                IdProfissional = Id
            };

            _context.Profissionais.Remove(profissional);
            return _context.SaveChanges();
        }

        public ProfissionalDto ListarPorId(int id)
        {
            return (from t in _context.Profissionais
                    where t.IdProfissional == id
                    select new ProfissionalDto()
                    {
                        IdProfissional = t.IdProfissional,
                        Nome = t.Nome,
                        Telefone = t.Telefone,
                        Endereco = t.Endereco,
                        Ativo = t.Ativo,

                    })
                    ?.FirstOrDefault()
                    ?? new ProfissionalDto();
        }

        public List<ProfissionalDto> ListarTodos()
        {
            return _context.Profissionais.Select(s => new ProfissionalDto()
            {
                IdProfissional = s.IdProfissional,
                Nome = s.Nome,
                Telefone = s.Telefone,
                Endereco = s.Endereco,
                Ativo = s.Ativo,
            }).ToList();
        }
    }


}
