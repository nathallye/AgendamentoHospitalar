using System;
using System.Collections.Generic;

namespace AgendamentoHospitalar.Modelos;

public partial class Hospital
{
    public int IdHospital { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cnpj { get; set; }

    public string? Endereço { get; set; }

    public string? Telefone { get; set; }

    public string? Cnes { get; set; }

    public bool Ativo { get; set; }

    public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; } = new List<AgendamentoConfiguracao>();

    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
}
