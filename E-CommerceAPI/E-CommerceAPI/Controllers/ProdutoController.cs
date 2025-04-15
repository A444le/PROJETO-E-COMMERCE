using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        //Injecao de dependencia = Ao inves de Eu instanciar a classe eu aviso que dependendo dela
        //E a responsabilidade de criar vem pra classe que chama (C#)
        public ProdutoController(ProdutoRepository produtoRepository)
        {

            _produtoRepository = produtoRepository;
        }
        [HttpGet]
        public IActionResult ListarProduto()
        {
            return Ok(_produtoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(Produto Produto)
        {
            _produtoRepository.Cadastrar(Produto);

            return Created();
        }
    

    }
}
