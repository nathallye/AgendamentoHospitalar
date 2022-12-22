using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using AgendamentoHospitalar.Repository.Context;

namespace AgendamentoHospitalar.Repository
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly DatabaseContext _context;

        public AgendamentoRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<AgendamentoOutDTO> ListarTodos()
        {
            return (from a in _context.Agendamentos

                    from h in _context.Hospitais
                    where h.IdHospital == a.IdHospital

                    from b in _context.Beneficiarios
                    where b.IdBeneficiario == a.IdBeneficiario

                    from e in _context.Especialidades
                    where e.IdEspecialidade == a.IdEspecialidade

                    from p in _context.Profissionais
                    where p.IdProfissional == a.IdProfissional

                    select new AgendamentoOutDTO()
                    {
                        Ativo = a.Ativo,
                        DataHoraAgendamento = a.DataHoraAgendamento,
                        IdAgendamento = a.IdAgendamento,
                        NomeBeneficiario = b.Nome,
                        NomeEspecialidade = e.Nome,
                        NomeHospital = h.Nome,
                        NomeProfissional = p.Nome
                    }).ToList();
        }

        public AgendamentoDto ListarPorId(int id)
        {
            return (from t in _context.Agendamentos
                    where t.IdAgendamento == id
                    select new AgendamentoDto()
                    {
                        IdAgendamento = t.IdAgendamento,
                        IdBeneficiario = t.IdBeneficiario,
                        IdHospital = t.IdHospital,
                        IdEspecialidade = t.IdEspecialidade,
                        IdProfissional = t.IdProfissional,
                        DataHoraAgendamento = t.DataHoraAgendamento,
                        Ativo = t.Ativo
                    })
                    ?.FirstOrDefault()
                    ?? new AgendamentoDto();
        }

        public Agendamento Criar(AgendamentoDto agendamento)
        {
            Agendamento agendamentoEntidade = new Agendamento()
            {
                IdBeneficiario = agendamento.IdBeneficiario,
                IdHospital = agendamento.IdHospital,
                IdEspecialidade = agendamento.IdEspecialidade,
                IdProfissional = agendamento.IdProfissional,
                DataHoraAgendamento = agendamento.DataHoraAgendamento,
                Ativo = agendamento.Ativo
            };

            _context.ChangeTracker.Clear();
            _context.Agendamentos.Add(agendamentoEntidade);
            _context.SaveChanges();
            return agendamentoEntidade;
        }

        public Agendamento Atualizar(AgendamentoAtualizarDto agendamento)
        {
            Agendamento agendamentoEntidadeBD =
                (from c in _context.Agendamentos
                 where c.IdAgendamento == agendamento.IdAgendamento
                 select c)
                 ?.FirstOrDefault()
                 ?? new Agendamento();

            if (agendamentoEntidadeBD == null || DBNull.Value.Equals(agendamentoEntidadeBD.IdAgendamento) || agendamentoEntidadeBD.IdAgendamento == 0)
            {
                return null;
            }

            Agendamento agendamentoEntidade = new Agendamento()
            {
                IdAgendamento = agendamento.IdAgendamento,
                IdBeneficiario = agendamento.IdBeneficiario,
                IdHospital = agendamento.IdHospital,
                IdEspecialidade = agendamento.IdEspecialidade,
                IdProfissional = agendamento.IdProfissional,
                DataHoraAgendamento = agendamento.DataHoraAgendamento,
                Ativo = agendamento.Ativo
            };

            _context.ChangeTracker.Clear();
            _context.Agendamentos.Update(agendamentoEntidade);
            _context.SaveChanges();
            return agendamentoEntidade;
        }

        public int Excluir(int id)
        {
            var agendamento = new Agendamento()
            {
                IdAgendamento = id
            };

            _context.Agendamentos.Remove(agendamento);
            return _context.SaveChanges();
        }
    }
}
