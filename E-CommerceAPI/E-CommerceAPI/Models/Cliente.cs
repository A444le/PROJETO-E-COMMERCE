using System;
using System.Collections.Generic;

namespace E_CommerceAPI.Models;


//ESTA PARTE SERIA A TABELA REF. AO DRAW.IO 
public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? NomeCompleto { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public DateOnly? DataCadastro { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
