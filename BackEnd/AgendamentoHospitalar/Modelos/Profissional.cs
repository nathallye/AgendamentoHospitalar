using System;
using System.Collections.Generic;

namespace AgendamentoHospitalar.Modelos;

public partial class Profissional
{
    public int IdProfissional { get; set; }

    public string Nome { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Endereço { get; set; }

    public bool Ativo { get; set; }

    public virtual ICollection<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; } = new List<AgendamentoConfiguracao>();

    public virtual ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();

    public virtual ICollection<DadosBancario> DadosBancarios { get; } = new List<DadosBancario>();
}
