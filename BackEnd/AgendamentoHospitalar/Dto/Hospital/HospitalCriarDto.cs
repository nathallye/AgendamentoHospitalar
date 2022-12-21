namespace AgendamentoHospitalar.Dto.Hospital
{
    public class HospitalCriarDto
    {
        public string Nome { get; set; } = null!;
        public string? Cnpj { get; set; }
        public string? Endereço { get; set; }
        public string? Telefone { get; set; }
        public string? Cnes { get; set; }
        public bool Ativo { get; set; }
    }
}
