using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
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

        //Ctor = Metodo Construtor 
        //Quando criar um objeto o que eu preciso ter?

        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }
        //GET 
        [HttpGet] //Retorna a lista de produtos 
        public IActionResult ListarProduto()
        {
            return Ok(_produtoRepository.ListarTodos());
        }
    }
}
