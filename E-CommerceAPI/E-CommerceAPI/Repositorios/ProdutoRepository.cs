using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace E_CommerceAPI.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        //Metodos que acessam o banco de dados 

        //Injetar o Context 
        //Injecao de Dependencia 

        //VARIAVEL PARA GUARDAR O CONTEXTO 
        private readonly EcommerceContext _context;

        //Ctor = Metodo Construtor 
        //Quando criar um objeto o que eu preciso ter?

        public ProdutoRepository(EcommerceContext context)
        {
        _context = context; 
        }

        public void Atualizar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
          _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
        return _context.Produtos.ToList();
        }
    }
}
