namespace E_CommerceAPI.DTO
{
    public class CadastrarPagamentosDto
    {
        public string FormadePagamento { get; set; } = null!;

        public string StatusPagamento { get; set; } = null!;

        public DateTime DataPagamento { get; set; }
    }
}
