using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceAPI.Repositorios
{
  
   
        public class PagamentoRepository : IPagamentoRepository
        {
           
            private readonly EcommerceContext _context;

           
            public PagamentoRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, CadastrarPagamentosDto pagamento)
            {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
            if (pagamentoEncontrado == null)
            {

                pagamentoEncontrado.FormadePagamento = pagamento.FormadePagamento;
                pagamentoEncontrado.StatusPagamento = pagamento.StatusPagamento;
                pagamentoEncontrado.DataPagamento = pagamento.DataPagamento;
               
                //pagamentoEncontrado.IdPedido = pagamento.IdPedido;
                _context.SaveChanges();
            }
        }

       
        public Pagamento BuscarPorId(int id)
            {
            return _context.Pagamentos.FirstOrDefault(p => p.IdPagamento == id);
        }
        //DTO
            public void Cadastrar(CadastrarPagamentosDto pagamento)
            {
            Pagamento pagamentoCadastro = new Pagamento
            {
                IdPagamento = pagamento.IdPagamento,
                FormadePagamento = pagamento.FormadePagamento,
                StatusPagamento = pagamento.StatusPagamento,
                DataPagamento = pagamento.DataPagamento

            };
                //_context.Pagamentos.Add(pagamentoCadastro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
            if (pagamentoEncontrado == null)
            {
                throw new Exception();
            }
            _context.Pagamentos.Remove(pagamentoEncontrado);
            _context.SaveChanges();
        }
            public List<Pagamento> ListarTodos()
            {
            return _context.Pagamentos.Include(p => p.IdPedidoNavigation).ToList();
            }
        }
    }