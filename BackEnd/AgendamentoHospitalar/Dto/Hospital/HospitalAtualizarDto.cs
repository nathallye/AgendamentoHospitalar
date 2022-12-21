namespace AgendamentoHospitalar.Dto.Hospital
{
    public class HospitalAtualizarDto
    {
        public int IdHospital { get; set; }
        public string? Nome { get; set; } = null!;
        public string? Cnpj { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Cnes { get; set; }
        public bool Ativo { get; set; }
    }
}
