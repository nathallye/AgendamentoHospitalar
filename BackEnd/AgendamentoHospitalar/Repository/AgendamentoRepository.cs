using AgendamentoHospitalar.Context;
using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;

namespace AgendamentoHospitalar.Repository
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly DatabaseContext _context;

        public AgendamentoRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<AgendamentoDto> ListarTodos()
        {
            return _context.Agendamentos.Select(s => new AgendamentoDto()
            {
                IdAgendamento = s.IdAgendamento,
                IdBeneficiario = s.IdBeneficiario,
                IdHospital = s.IdHospital,
                IdEspecialidade = s.IdEspecialidade,
                IdProfissional = s.IdProfissional,
                DataHoraAgendamento = s.DataHoraAgendamento,
                Ativo = s.Ativo
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

        public Agendamento Criar(AgendamentoCriarDto agendamento)
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
    }
}
