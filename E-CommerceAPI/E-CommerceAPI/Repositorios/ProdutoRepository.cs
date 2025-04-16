using System.Linq;
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
            Produto produtoEncontrado = _context.Produtos.Find(id);
            if (produtoEncontrado == null)
            {

                throw new Exception();
            }
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

            _context.SaveChanges();
        }

        public Produto BuscarPorId(int id)
        {
            //ToList() - Pegar varios 
            //FirstorDefault - Traz o primeiro que encontrar, ou null


            //Funcao Lambida

            //significado 
            //_context.Produtos - Acesse a tabela Produtos do Contexto
            //FirstOrDeDefault - Pegue o primeiro que encontrar p => p.IdProduto == id para cada prduto P, me retorne aquele que tem o IdProduto igual ao Id
            return _context.Produtos.FirstOrDefault(p => p.IdProduto == id);
        }

        public void Cadastrar(Produto produto)
        {
          _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //1 - Encontrar o que eu quero Excluir 
            Produto ProdutoEncontrado = _context.Produtos.Find(id);
            //Caso nao encontre o produto, lanco um erro
            if (ProdutoEncontrado == null)
            {
                throw new Exception();
            }
            //Caso eu encontre o produto, removo ele
            _context.Produtos.Remove(ProdutoEncontrado);
            //Salvo as alteracoes
            _context.SaveChanges();

        }

        public List<Produto> ListarTodos()
        {
        return _context.Produtos.ToList();
        }
    }
}
