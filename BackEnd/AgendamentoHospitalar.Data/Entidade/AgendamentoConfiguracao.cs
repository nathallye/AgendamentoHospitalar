using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

[Table("AgendamentoConfiguracao")]
[Index("IdHospital", "IdEspecialidade", "IdProfissional", "DataHoraInicioAtendimento", "DataHoraFinalAtendimento", Name = "UC_AgendamentoConfiguracao", IsUnique = true)]
public partial class AgendamentoConfiguracao
{
    [Key]
    public int IdConfiguracao { get; set; }

    public int IdHospital { get; set; }

    public int IdEspecialidade { get; set; }

    public int IdProfissional { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHoraInicioAtendimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHoraFinalAtendimento { get; set; }

    [ForeignKey("IdEspecialidade")]
    [InverseProperty("AgendamentoConfiguracaos")]
    public virtual Especialidade IdEspecialidadeNavigation { get; set; } = null!;

    [ForeignKey("IdHospital")]
    [InverseProperty("AgendamentoConfiguracaos")]
    public virtual Hospital IdHospitalNavigation { get; set; } = null!;

    [ForeignKey("IdProfissional")]
    [InverseProperty("AgendamentoConfiguracaos")]
    public virtual Profissional IdProfissionalNavigation { get; set; } = null!;
}
