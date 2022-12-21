using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

[Table("Profissional")]
public partial class Profissional
{
    [Key]
    public int IdProfissional { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [Unicode(false)]
    public string? Endereço { get; set; }

    public bool Ativo { get; set; }

    [InverseProperty("IdProfissionalNavigation")]
    public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; } = new List<AgendamentoConfiguracao>();

    [InverseProperty("IdProfissionalNavigation")]
    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();

    [InverseProperty("IdProfissionalNavigation")]
    public virtual ICollection<DadosBancario> DadosBancarios { get; } = new List<DadosBancario>();
}
