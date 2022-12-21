namespace AgendamentoHospitalar.Dto.Agendamento
{
    public class AgendamentoDto
    {
        public int IdAgendamento { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdHospital { get; set; }
        public int IdEspecialidade { get; set; }
        public int IdProfissional { get; set; }
        public DateTime DataHoraAgendamento { get; set; } 
        public bool Ativo { get; set; }
        public virtual Entidade.Beneficiario IdBeneficiarioNavigation { get; set; } = null!;
        public virtual Entidade.Especialidade IdEspecialidadeNavigation { get; set; } = null!;
        public virtual Entidade.Hospital IdHospitalNavigation { get; set; } = null!;
        public virtual Entidade.Profissional IdProfissionalNavigation { get; set; } = null!;
    }
}
