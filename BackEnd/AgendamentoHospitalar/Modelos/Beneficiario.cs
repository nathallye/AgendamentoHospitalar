using System;
using System.Collections.Generic;

namespace AgendamentoHospitalar.Modelos;

public partial class Beneficiario
{
    public int IdBeneficiario { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public string NumeroCarteirinha { get; set; } = null!;

    public bool Ativo { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
}
