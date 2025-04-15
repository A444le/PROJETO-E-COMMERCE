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
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _pedidoRepository;
        public PedidoController(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(Pedido Pedido)
        {
            _pedidoRepository.Cadastrar(Pedido);

          

            return Created();
        }
    }
}
