namespace AgendamentoHospitalar.Dto.Profissional
{
    public class ProfissionalDto
    {
        public int IdProfissional { get; set; }

        public string Nome { get; set; } = null!;

        public string? Telefone { get; set; }

        public string? Endereço { get; set; }

        public bool Ativo { get; set; }
    }
}
