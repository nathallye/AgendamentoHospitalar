using AgendamentoHospitalar.Repository.Context;
using AgendamentoHospitalar.Interface;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Dto.Beneficiario;

namespace AgendamentoHospitalar.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        private readonly DatabaseContext _context;

        public BeneficiarioRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<BeneficiarioDto> ListarTodos()
        {
            return _context.Beneficiario.Select(s => new BeneficiarioDto()
            {
                IdBeneficiario = s.IdBeneficiario,
                Nome = s.Nome,
                Cpf = s.Cpf,
                Telefone = s.Telefone,
                Endereco = s.Endereco,
                NumeroCarteirinha = s.NumeroCarteirinha,
                Ativo = s.Ativo,
                Email = s.Email
            }).ToList();
        }

        public BeneficiarioDto ListarPorId(int id)
        {
            return (from t in _context.Beneficiario
                    where t.IdBeneficiario == id
                    select new BeneficiarioDto()
                    {
                        IdBeneficiario = t.IdBeneficiario,
                        Nome = t.Nome,
                        Cpf = t.Cpf,
                        Telefone = t.Telefone,
                        Endereco = t.Endereco,
                        NumeroCarteirinha = t.NumeroCarteirinha,
                        Ativo = t.Ativo,
                        Email = t.Email

                    })
                    ?.FirstOrDefault()
                    ?? new BeneficiarioDto();
        }

        public Beneficiario Criar(BeneficiarioCriarDto beneficiario)
        {
            Beneficiario beneficiarioEntidade = new Beneficiario()
            {
                Nome = beneficiario.Nome,
                Cpf = beneficiario.Cpf,
                Telefone = beneficiario.Telefone,
                Endereco = beneficiario.Endereco,
                NumeroCarteirinha = beneficiario.NumeroCarteirinha,
                Ativo = beneficiario.Ativo,
                Email = beneficiario.Email,
                Senha = beneficiario.Senha
            };

            _context.ChangeTracker.Clear();
            _context.Beneficiario.Add(beneficiarioEntidade);
            _context.SaveChanges();
            return beneficiarioEntidade;
        }

        public Beneficiario Atualizar(BeneficiarioAtualizarDto beneficiario)
        {
            Beneficiario beneficiarioEntidadeBD =
                (from c in _context.Beneficiario
                 where c.IdBeneficiario == beneficiario.IdBeneficiario
                 select c)
                 ?.FirstOrDefault()
                 ?? new Beneficiario();

            if (beneficiarioEntidadeBD == null || DBNull.Value.Equals(beneficiarioEntidadeBD.IdBeneficiario) || beneficiarioEntidadeBD.IdBeneficiario == 0)
            {
                return null;
            }

            Beneficiario beneficiarioEntidade = new Beneficiario()
            {
                Nome = (beneficiario.Nome != null ? beneficiario.Nome : beneficiarioEntidadeBD.Nome),
                Cpf = (beneficiario.Cpf != null ? beneficiario.Cpf : beneficiarioEntidadeBD.Cpf),
                Telefone = (beneficiario.Telefone != null ? beneficiario.Telefone : beneficiarioEntidadeBD.Telefone),
                Endereco = (beneficiario.Endereco != null ? beneficiario.Endereco : beneficiarioEntidadeBD.Endereco),
                NumeroCarteirinha = (beneficiario.NumeroCarteirinha != null ? beneficiario.NumeroCarteirinha : beneficiarioEntidadeBD.NumeroCarteirinha),
                Ativo = beneficiario.Ativo,
                Email = (beneficiario.Email != null ? beneficiario.Email : beneficiarioEntidadeBD.Email),
                Senha = (beneficiario.Senha != null ? beneficiario.Senha : beneficiarioEntidadeBD.Senha)
            };

            _context.ChangeTracker.Clear();
            _context.Beneficiario.Add(beneficiarioEntidade);
            _context.SaveChanges();
            return beneficiarioEntidade;
        }

        public int Excluir(int id)
        {
            var beneficiario = new Beneficiario()
            {
                IdBeneficiario = id
            };

            _context.Beneficiario.Remove(beneficiario);
            return _context.SaveChanges();
        }
    }
}
