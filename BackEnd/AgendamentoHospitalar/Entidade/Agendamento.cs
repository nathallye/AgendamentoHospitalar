using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

[Table("Agendamento")]
[Index("IdHospital", "IdEspecialidade", "IdProfissional", "IdBeneficiario", "DataHoraAgendamento", Name = "UC_Agendamento", IsUnique = true)]
public partial class Agendamento
{
    [Key]
    [Column("idAgendamento")]
    public int IdAgendamento { get; set; }

    [Column("idHospital")]
    public int IdHospital { get; set; }

    [Column("idEspecialidade")]
    public int IdEspecialidade { get; set; }

    [Column("idProfissional")]
    public int IdProfissional { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataHoraAgendamento { get; set; }

    [Column("idBeneficiario")]
    public int IdBeneficiario { get; set; }

    public bool Ativo { get; set; }

    [ForeignKey("IdBeneficiario")]
    [InverseProperty("Agendamentos")]
    public virtual Beneficiario IdBeneficiarioNavigation { get; set; } = null!;

    [ForeignKey("IdEspecialidade")]
    [InverseProperty("Agendamentos")]
    public virtual Especialidade IdEspecialidadeNavigation { get; set; } = null!;

    [ForeignKey("IdHospital")]
    [InverseProperty("Agendamentos")]
    public virtual Hospital IdHospitalNavigation { get; set; } = null!;

    [ForeignKey("IdProfissional")]
    [InverseProperty("Agendamentos")]
    public virtual Profissional IdProfissionalNavigation { get; set; } = null!;
}
