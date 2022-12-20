namespace AgendamentoHospitalar.Dto.Profissional
{
    public class ProfissionalAtualizarDto
    {
        public int IdProfissional { get; set; }

        public string? Nome { get; set; }

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }

        public bool Ativo { get; set; }
    }
}
