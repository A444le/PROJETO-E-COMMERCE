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
        private readonly EcommerceContext _context;
        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
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

            _context.SaveChanges();

            return Created();
        }
    

    }
}
