using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _pedidoRepository;
        private readonly EcommerceContext _context;

        public PedidoController(EcommerceContext context)
        {
            _context = context;
            _pedidoRepository = new PedidoRepository(_context);
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
    }
}
