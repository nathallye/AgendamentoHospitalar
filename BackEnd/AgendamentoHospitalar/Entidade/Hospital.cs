using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade
{
    [Table("Hospital")]
    public partial class Hospital
    {
        public Hospital()
        {
            AgendamentoConfiguracaos = new HashSet<AgendamentoConfiguracao>();
            Agendamentos = new HashSet<Agendamento>();
        }

        [Key]
        [Column("idHospital")]
        public int IdHospital { get; set; }
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [Column("CNPJ")]
        [StringLength(25)]
        [Unicode(false)]
        public string? Cnpj { get; set; }
        [Unicode(false)]
        public string? Endereço { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? Telefone { get; set; }
        [Column("CNES")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cnes { get; set; }
        public bool Ativo { get; set; }

        [InverseProperty("IdHospitalNavigation")]
        public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; set; }
        [InverseProperty("IdHospitalNavigation")]
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
