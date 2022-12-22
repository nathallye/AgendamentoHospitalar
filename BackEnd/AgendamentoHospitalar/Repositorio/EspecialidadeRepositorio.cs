using AgendamentoHospitalar.DTO;
using AgendamentoHospitalar.Interfaces;
using AgendamentoHospitalar.Modelos;

namespace AgendamentoHospitalar.Repositorio
{
    public class EspecialidadeRepositorio : IEspecialidadeRepositorio
    {
        private MasterContext _contexto { get; set; }
        public EspecialidadeRepositorio()
        {
            _contexto = new MasterContext();
        }
        public int Inserir(EspecialidadeDTO novaEspecialidadeDTO)
        {
            var novaEspecialidade = new Especialidade()
            {
                Nome = novaEspecialidadeDTO.Nome,
                Ativo = novaEspecialidadeDTO.Ativo,
                Descricao = novaEspecialidadeDTO.Descricao
            };
            _contexto.Especialidades.Add(novaEspecialidade);
            return _contexto.SaveChanges();
        }


        public List<EspecialidadeDTO> ListarTodas()
        {
            return _contexto.Especialidades.Select(s => new EspecialidadeDTO()
            {
                Nome = s.Nome,
                Ativo = s.Ativo,
                Descricao = s.Descricao,
                IdEspecialidade= s.IdEspecialidade,

            }).ToList();
        }


        public EspecialidadeDTO PorId(int id)
        {
            return (from t in _contexto.Especialidades
                    where t.IdEspecialidade == id
                    select new EspecialidadeDTO()
                    {
                        Ativo= t.Ativo,
                        Descricao = t.Descricao,
                        Nome = t.Nome,
                        IdEspecialidade = t.IdEspecialidade
                    })
                    ?.FirstOrDefault()
                    ?? new EspecialidadeDTO();
        }

        public int Atualizar(EspecialidadeDTO atualizacaodto)
        {
            Especialidade especialidadeBanco =
                 (from c in _contexto.Especialidades
                  where c.IdEspecialidade == atualizacaodto.IdEspecialidade
                  select c)
                  ?.FirstOrDefault()
                  ?? new Especialidade();

            // TRATAMENTO DE ERRO
            // CASO NÃO ACHE O ID PARA ATUALIZAR, RETORNA VALOR 0. 
            // OU SEJA, NÃO ATUALIZOU NENHUM CADASTRO
            if (especialidadeBanco == null || DBNull.Value.Equals(especialidadeBanco.IdEspecialidade) || especialidadeBanco.IdEspecialidade == 0)
            {
                return 0;
            }

            var especialidadeAtualizado = new Especialidade()
            {
                IdEspecialidade = especialidadeBanco.IdEspecialidade,
                Nome = atualizacaodto.Nome,
                Ativo = atualizacaodto.Ativo,
                Descricao = atualizacaodto.Descricao
            };

            _contexto.ChangeTracker.Clear();
            _contexto.Especialidades.Update(especialidadeAtualizado);
            return _contexto.SaveChanges();
        }

        public int Excluir(int Id)
        {
            Especialidade especialidadeBanco=
                (from c in _contexto.Especialidades
                 where c.IdEspecialidade == Id
                 select c).FirstOrDefault();

            if (especialidadeBanco == null || DBNull.Value.Equals(especialidadeBanco.IdEspecialidade) || especialidadeBanco.IdEspecialidade == 0)
            {
                return 0;
            }
            _contexto.ChangeTracker.Clear();
            _contexto.Especialidades.Remove(especialidadeBanco);
            return _contexto.SaveChanges();
        }
    }
}
