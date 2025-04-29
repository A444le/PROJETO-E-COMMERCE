namespace E_CommerceAPI.DTO
{
    public class CadastrarPagamentosDto
    {
        public int IdPagamento { get; set; }
        public int IdPedido { get; set; }
        public string FormadePagamento { get; set; } = null!;

        public string StatusPagamento { get; set; } = null!;

        public DateTime DataPagamento { get; set; }
    }
}
