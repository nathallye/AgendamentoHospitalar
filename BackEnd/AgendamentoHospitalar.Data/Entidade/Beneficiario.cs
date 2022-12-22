using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

[Table("Beneficiario")]
public class Beneficiario
{
    [Key]
    [Column("idBeneficiario")]
    public int IdBeneficiario { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string Cpf { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Endereco { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string NumeroCarteirinha { get; set; } = null!;

    public bool Ativo { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(30)]
    [Unicode(false)]
    public string Senha { get; set; } = null!;

    [InverseProperty("IdBeneficiarioNavigation")]
    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
}
