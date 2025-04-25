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
    public class ItemDoPedidoController : ControllerBase
    {
        private IItemDoPedidoRepository _ItemDoPedidoRepository;
        public ItemDoPedidoController(IItemDoPedidoRepository itemDoPedidoRepository)
        {
            _ItemDoPedidoRepository = itemDoPedidoRepository;
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_ItemDoPedidoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(ItemPedido itemDoPedido)
        {

            _ItemDoPedidoRepository.Cadastrar(itemDoPedido);


            return Created();
        }
    }
}

