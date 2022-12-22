namespace AgendamentoHospitalar.Dto.Agendamento
{
    public class AgendamentoOutDTO
    {
        public int IdAgendamento { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomeHospital { get; set; }
        public string NomeEspecialidade { get; set; }
        public string NomeProfissional { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public bool Ativo { get; set; }
    }
}
