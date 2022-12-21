using System;
using System.Collections.Generic;

namespace AgendamentoHospitalar.Modelos;

public partial class Agendamento
{
    public int IdAgendamento { get; set; }

    public int IdHospital { get; set; }

    public int IdEspecialidade { get; set; }

    public int IdProfissional { get; set; }

    public DateTime DataHoraAgendamento { get; set; }

    public int IdBeneficiario { get; set; }

    public bool Ativo { get; set; }

    public virtual Beneficiario IdBeneficiarioNavigation { get; set; } = null!;

    public virtual Especialidade IdEspecialidadeNavigation { get; set; } = null!;

    public virtual Hospital IdHospitalNavigation { get; set; } = null!;

    public virtual Profissional IdProfissionalNavigation { get; set; } = null!;
}
