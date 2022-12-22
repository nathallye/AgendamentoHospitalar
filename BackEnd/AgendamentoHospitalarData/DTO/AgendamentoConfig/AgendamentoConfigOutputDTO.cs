namespace AgendamentoHospitalar.DTO.AgendamentoConfig
{
    public class AgendamentoConfigOutputDTO
    {
        public int IdConfiguracao { get; set; }

        public string NomeHospital { get; set; }
        public int IdHospital { get; set; }

        public string NomeEspecialidade { get; set; }
        public int IdEspecialidade { get; set; }

        public string NomeProfissional { get; set; }
        public int IdProfissional { get; set; }

        public DateTime DataHoraInicioAtendimento { get; set; }

        public DateTime DataHoraFinalAtendimento { get; set; }
    }
}
