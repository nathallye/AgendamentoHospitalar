using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade
{
    [Table("Profissional")]
    public partial class Profissional
    {
        public Profissional()
        {
            AgendamentoConfiguracaos = new HashSet<AgendamentoConfiguracao>();
            Agendamentos = new HashSet<Agendamento>();
            DadosBancarios = new HashSet<DadosBancario>();
        }

        [Key]
        public int IdProfissional { get; set; }
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [StringLength(15)]
        [Unicode(false)]
        public string? Telefone { get; set; }
        [Unicode(false)]
        public string? Endereco { get; set; }
        public bool Ativo { get; set; }

        [InverseProperty("IdProfissionalNavigation")]
        public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; set; }
        [InverseProperty("IdProfissionalNavigation")]
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
        [InverseProperty("IdProfissionalNavigation")]
        public virtual ICollection<DadosBancario> DadosBancarios { get; set; }
    }
}
