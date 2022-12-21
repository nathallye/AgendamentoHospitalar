using AgendamentoHospitalar.Context;
using AgendamentoHospitalar.Dto.Agendamento;
using AgendamentoHospitalar.Dto.Beneficiario;
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
    }
}
