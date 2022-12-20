using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade
{
    [Table("Especialidade")]
    public partial class Especialidade
    {
        public Especialidade()
        {
            AgendamentoConfiguracaos = new HashSet<AgendamentoConfiguracao>();
            Agendamentos = new HashSet<Agendamento>();
        }

        [Key]
        public int IdEspecialidade { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [Unicode(false)]
        public string? Descrição { get; set; }
        public bool Ativo { get; set; }

        [InverseProperty("IdEspecialidadeNavigation")]
        public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; set; }
        [InverseProperty("IdEspecialidadeNavigation")]
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
