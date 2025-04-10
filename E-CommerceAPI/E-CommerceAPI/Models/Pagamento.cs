using System;
using System.Collections.Generic;

namespace E_CommerceAPI.Models;

public partial class Pagamento
{
    public int IdPagamento { get; set; }

    public int? IdPedido { get; set; }

    public string? FormadePagamento { get; set; }

    public string? StatusPagamento { get; set; }

    public DateTime? DataPagamento { get; set; }

    public virtual Pedido? IdPedidoNavigation { get; set; }
}
