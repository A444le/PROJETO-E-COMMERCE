using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;

namespace E_CommerceAPI.Repositorios
{
  
   
        public class PagamentoRepository : IpagamentoRepository
        {
           
            private readonly EcommerceContext _context;

           
            public PagamentoRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, Pagamento Pagamento)
            {
                throw new NotImplementedException();
            }

            public Pagamento BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Pagamento Pagamento)
            {
                _context.Pagamentos.Add(Pagamento);
            }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Pagamento> ListarTodos()
            {
                return _context.Pagamentos.ToList();
            }
        }
    }


