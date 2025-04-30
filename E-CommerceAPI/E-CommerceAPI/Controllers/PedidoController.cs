using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
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
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarPedidoDto Pedido)
        {
            _pedidoRepository.Cadastrar(Pedido);



            return Created();
        }


        [HttpPut("{id}")]
        public IActionResult Editar(int id, CadastrarPedidoDto pedido)
        {
            try
            {
                _pedidoRepository.Atualizar(id, pedido);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Pedido nao encontrado!");
            }

        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _pedidoRepository.Deletar(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return NotFound("Pedido nao encontrado!");
            }
        }
    }
}
