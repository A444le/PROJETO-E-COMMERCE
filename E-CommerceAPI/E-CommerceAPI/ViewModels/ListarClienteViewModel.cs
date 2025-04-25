namespace E_CommerceAPI.ViewModels
{
    public class ListarClienteViewModel
    {
        public int IdCliente { get; set; }

        public string NomeCompleto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefone { get; set; } = null!;

        public string Endereco { get; set; } = null!;

        public DateOnly? DataCadastro { get; set; }



    }
}
