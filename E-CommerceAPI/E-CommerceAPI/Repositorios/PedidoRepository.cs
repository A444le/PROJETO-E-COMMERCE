using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
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


        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }


        public Pedido BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }



        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }



        public void Cadastrar(CadastrarPedidoDto pedidoDto)
        { 
            //Crio o pedido
            //Crio uma variavel pedido, para guardar as informacoes do pedido
            var pedido = new Pedido
            {
                DataPedido = pedidoDto.DataPedido,
                StatusPedido = pedidoDto.StatusPedido,  
                IdCliente = pedidoDto.IdCliente,    
                ValorTotal = pedidoDto.ValorTotal
            };
            _context.Pedidos.Add(pedido);
            _context.SaveChanges(); // Sempre colocar o SaveChanges quando for mudar algo no Banco de Dados
            //Cadastrar os ItensPedido
            //Para cada PRODUTO, eu crio ItemPedido



            for (int i = 0; i < pedidoDto.Produtos.Count; i++)
            {
                var produto = _context.Produtos.Find(pedidoDto.Produtos[i]); //ENCONTRA UM PRODUTO
                // TODO: lancar erro se produto nao existe 

                //CRIO UMA VARIAVEL ItemPedido
                var itemPedido = new ItemPedido 
                {
                    IdPedido = pedido.IdPedido,
                    IdProduto = produto.IdProduto,
                    Quantidade = 0
                    
                };
                _context.ItemPedidos.Add(itemPedido); //JOGO NO BANCO DE DADOS
                _context.SaveChanges(); //SALVO

                
                
            }
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