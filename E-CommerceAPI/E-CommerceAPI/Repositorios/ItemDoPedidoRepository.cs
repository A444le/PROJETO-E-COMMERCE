﻿using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;

namespace E_CommerceAPI.Repositorios
{
   
    
        public class ItemDoPedidoRepository : IItemDoPedidoRepository
        {
           
            private readonly EcommerceContext _context;

            public ItemDoPedidoRepository(EcommerceContext context)
            {
                _context = context;
            }

        public void Atualizar(int id, ItemPedido itemPedido)
        {
            throw new NotImplementedException();
        }

        public ItemPedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ItemPedido itemPedido)
        {
            _context.ItemPedidos.Add(itemPedido);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemPedido> ListarTodos()
        {
 
            return _context.ItemPedidos.ToList();
        }
    }
    }


