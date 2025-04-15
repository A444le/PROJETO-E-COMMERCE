using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;

namespace E_CommerceAPI.Repositorios
{
    public class PedidoRepository : IPedidoRepository
    {
      
        
            //Metodos que acessam o banco de dados 

            //Injetar o Context 
            //Injecao de Dependencia 

            //VARIAVEL PARA GUARDAR O CONTEXTO 
            private readonly EcommerceContext _context;

            //Ctor = Metodo Construtor 
            //Quando criar um objeto o que eu preciso ter?

            public PedidoRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, Pedido Pedido)
            {
                throw new NotImplementedException();
            }

            public Pedido BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Pedido Pedido)
            {
                _context.Pedidos.Add(Pedido);
            _context.SaveChanges();
        }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Pedido> ListarTodos()
            {
                return _context.Pedidos.ToList();
            }
        }
    }


