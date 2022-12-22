namespace AgendamentoHospitalar.Dto.Beneficiario
{
    public class BeneficiarioAtualizarDto
    {
        public int IdBeneficiario { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; } 
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? NumeroCarteirinha { get; set; }
        public bool Ativo { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
