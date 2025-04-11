using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemDoPedidoController : ControllerBase
    {
        private IProdutoRepository _ItemdoPedidoRepository;
        private readonly EcommerceContext _context;

        public ItemDoPedidoController(EcommerceContext context)
        {
            _context = context;
            _ItemdoPedidoRepository = new ItemDoPedidoRepository(_context);
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_ItemdoPedidoRepository.ListarTodos());
        }
    }
}
