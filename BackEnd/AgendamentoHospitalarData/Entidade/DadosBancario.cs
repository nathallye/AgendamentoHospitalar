using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Entidade;

public partial class DadosBancario
{
    [Key]
    public int IdDadosBancarios { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string NumeroBanco { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? CodigoPix { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Agencia { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NumeroConta { get; set; }

    public bool? Poupanca { get; set; }

    [Column("idProfissional")]
    public int IdProfissional { get; set; }

    [ForeignKey("IdProfissional")]
    [InverseProperty("DadosBancarios")]
    public virtual Profissional IdProfissionalNavigation { get; set; } = null!;
}
