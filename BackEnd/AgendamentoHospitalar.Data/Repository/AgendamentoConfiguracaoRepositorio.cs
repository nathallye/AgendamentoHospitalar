using AgendamentoHospitalar.DTO.AgendamentoConfig;
using AgendamentoHospitalar.Entidade;
using AgendamentoHospitalar.Interface;
using AgendamentoHospitalar.Repository.Context;

namespace AgendamentoHospitalar.Repository
{
    public class AgendamentoConfiguracaoRepositorio : IAgendamentoConfiguracaoRepositorio
    {
        private DatabaseContext _contexto { get; set; }
        public AgendamentoConfiguracaoRepositorio(DatabaseContext context)
        {
            _contexto = context;
        }
        public int Atualizar(AgendamentoConfiguracaoDTO atualizacaodto)
        {
            AgendamentoConfiguracao agendamentoConfigBanco =
                (from c in _contexto.AgendamentoConfiguracaos
                 where c.IdEspecialidade == atualizacaodto.IdConfiguracao
                 select c)
                 ?.FirstOrDefault()
                 ?? new AgendamentoConfiguracao();

            // TRATAMENTO DE ERRO
            // CASO NÃO ACHE O ID PARA ATUALIZAR, RETORNA VALOR 0. 
            // OU SEJA, NÃO ATUALIZOU NENHUM CADASTRO
            if (agendamentoConfigBanco == null || DBNull.Value.Equals(agendamentoConfigBanco.IdEspecialidade) || agendamentoConfigBanco.IdEspecialidade == 0)
            {
                return 0;
            }

            var especialidadeAtualizado = new AgendamentoConfiguracao()
            {
                IdConfiguracao = agendamentoConfigBanco.IdConfiguracao,
                IdHospital = atualizacaodto.IdHospital,
                IdEspecialidade = atualizacaodto.IdEspecialidade,
                IdProfissional = atualizacaodto.IdProfissional,
                DataHoraFinalAtendimento = atualizacaodto.DataHoraFinalAtendimento,
                DataHoraInicioAtendimento = atualizacaodto.DataHoraInicioAtendimento

            };

            _contexto.ChangeTracker.Clear();
            _contexto.AgendamentoConfiguracaos.Update(especialidadeAtualizado);
            return _contexto.SaveChanges();
        }

        public int Excluir(int Id)
        {
            AgendamentoConfiguracao agendamentoConfigBanco =
                 (from c in _contexto.AgendamentoConfiguracaos
                  where c.IdEspecialidade == Id
                  select c)
                  ?.FirstOrDefault();

            if (agendamentoConfigBanco == null || DBNull.Value.Equals(agendamentoConfigBanco.IdEspecialidade) || agendamentoConfigBanco.IdEspecialidade == 0)
            {
                return 0;
            }
            _contexto.ChangeTracker.Clear();
            _contexto.AgendamentoConfiguracaos.Remove(agendamentoConfigBanco);
            return _contexto.SaveChanges();
        }
        public int Inserir(AgendamentoConfiguracaoDTO novaEspecialidadeDTO)
        {
            var novoAgendamentoConfig = new AgendamentoConfiguracao()
            {
                IdConfiguracao = novaEspecialidadeDTO.IdConfiguracao,
                IdHospital = novaEspecialidadeDTO.IdHospital,
                IdEspecialidade = novaEspecialidadeDTO.IdEspecialidade,
                IdProfissional = novaEspecialidadeDTO.IdProfissional,
                DataHoraInicioAtendimento = novaEspecialidadeDTO.DataHoraInicioAtendimento,
                DataHoraFinalAtendimento = novaEspecialidadeDTO.DataHoraFinalAtendimento

            };
            _contexto.AgendamentoConfiguracaos.Add(novoAgendamentoConfig);
            return _contexto.SaveChanges();
        }

        public List<AgendamentoConfigOutputDTO> ListarTodos()
        {
            return (from b in _contexto.AgendamentoConfiguracaos

                    from c in _contexto.Especialidades
                    where c.IdEspecialidade == b.IdEspecialidade

                    from x in _contexto.Profissionais
                    where x.IdProfissional == b.IdProfissional

                    from h in _contexto.Hospitais
                    where h.IdHospital == b.IdHospital

                    select new AgendamentoConfigOutputDTO()
                    {
                        NomeHospital = h.Nome,
                        DataHoraFinalAtendimento = b.DataHoraFinalAtendimento,
                        DataHoraInicioAtendimento = b.DataHoraInicioAtendimento,
                        IdConfiguracao = b.IdConfiguracao,
                        NomeEspecialidade = c.Nome,
                        NomeProfissional = x.Nome
                    }
                      ).ToList();
        }

        public AgendamentoConfiguracaoDTO PorId(int id)
        {
            return (from s in _contexto.AgendamentoConfiguracaos
                    where s.IdConfiguracao == id
                    select new AgendamentoConfiguracaoDTO()
                    {
                        IdConfiguracao = s.IdConfiguracao,
                        IdHospital = s.IdHospital,
                        IdEspecialidade = s.IdEspecialidade,
                        IdProfissional = s.IdProfissional,
                        DataHoraInicioAtendimento = s.DataHoraInicioAtendimento,
                        DataHoraFinalAtendimento = s.DataHoraFinalAtendimento
                    })
                     ?.FirstOrDefault()
                     ?? new AgendamentoConfiguracaoDTO();
        }

        public AgendamentoConfigOutputDTO ListarJoin(int id)
        {
            return (from b in _contexto.AgendamentoConfiguracaos
                    where b.IdConfiguracao == id

                    from c in _contexto.Especialidades
                    where c.IdEspecialidade == b.IdEspecialidade

                    from x in _contexto.Profissionais
                    where x.IdProfissional == b.IdProfissional

                    from h in _contexto.Hospitais
                    where h.IdHospital == b.IdHospital

                    select new AgendamentoConfigOutputDTO()
                    {
                        NomeHospital = h.Nome,
                        DataHoraFinalAtendimento = b.DataHoraFinalAtendimento,
                        DataHoraInicioAtendimento = b.DataHoraInicioAtendimento,
                        IdConfiguracao = b.IdConfiguracao,
                        NomeEspecialidade = c.Nome,
                        NomeProfissional = x.Nome
                    }
                    ).SingleOrDefault();
        }
    }
}
