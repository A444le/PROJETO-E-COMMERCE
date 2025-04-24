namespace E_CommerceAPI.DTO
{
    public class CadastrarClientesDto
    {
        public string NomeCompleto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefone { get; set; } = null!;

        public string Endereco { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public DateOnly? DataCadastro { get; set; }
    }
}
