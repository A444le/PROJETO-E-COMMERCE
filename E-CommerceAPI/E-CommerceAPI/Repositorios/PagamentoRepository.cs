using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceAPI.Repositorios
{
  
   
        public class PagamentoRepository : IpagamentoRepository
        {
           
            private readonly EcommerceContext _context;

           
            public PagamentoRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, CadastrarPagamentosDto Pagamento)
            {
                throw new NotImplementedException();
            }

            public Pagamento BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }
        //DTO
            public void Cadastrar(CadastrarPagamentosDto Pagamento)
            {
            Pagamento produtoCadastro = new Pagamento
            {
                FormadePagamento = Pagamento.FormadePagamento,
                StatusPagamento = Pagamento.StatusPagamento,
                DataPagamento = Pagamento.DataPagamento,

            };
                _context.Pagamentos.Add(produtoCadastro);
            _context.SaveChanges();
        }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Pagamento> ListarTodos()
            {
            return _context.Pagamentos.Include(p => p.IdPedidoNavigation).ToList();
            }
        }
    }


