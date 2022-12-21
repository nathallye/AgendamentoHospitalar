using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

[Table("Especialidade")]
public partial class Especialidade
{
    [Key]
    public int IdEspecialidade { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Unicode(false)]
    public string? Descricao { get; set; }

    public bool Ativo { get; set; }

    [InverseProperty("IdEspecialidadeNavigation")]
    public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; } = new List<AgendamentoConfiguracao>();

    [InverseProperty("IdEspecialidadeNavigation")]
    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
}
