﻿using System;
using System.Collections.Generic;

namespace E_CommerceAPI.Models;

//ESTA PARTE SERIA A TABELA REF. AO DRAW.IO 

public partial class Produto
{
    public int IdProduto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? EstoqueDisponivel { get; set; }

    public string? Categoria { get; set; }

    public string? Imagem { get; set; }

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
}
