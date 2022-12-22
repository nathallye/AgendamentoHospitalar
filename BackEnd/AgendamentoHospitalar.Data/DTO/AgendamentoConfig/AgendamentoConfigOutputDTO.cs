namespace AgendamentoHospitalar.DTO.AgendamentoConfig
{
    public class AgendamentoConfigOutputDTO
    {
        public int IdConfiguracao { get; set; }

        public string NomeHospital { get; set; }

        public string NomeEspecialidade { get; set; }

        public string NomeProfissional { get; set; }

        public DateTime DataHoraInicioAtendimento { get; set; }

        public DateTime DataHoraFinalAtendimento { get; set; }
    }
}
