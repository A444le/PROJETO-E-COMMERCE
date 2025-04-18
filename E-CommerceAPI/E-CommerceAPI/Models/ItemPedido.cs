using System;
using System.Collections.Generic;

namespace E_CommerceAPI.Models;

public partial class ItemPedido
{
    public int IdItemdoPedido { get; set; }

    public int IdPedido { get; set; }

    public int IdProduto { get; set; }

    public int Quantidade { get; set; }

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Produto IdProdutoNavigation { get; set; } = null!;
}
