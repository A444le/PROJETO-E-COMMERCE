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
    public class PagamentoController : ControllerBase
    {
        private IPagamentoRepository _pagamentoRepository;
        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }
        [HttpGet]
        public IActionResult ListarProduto()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }


        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarPagamentosDto pagamento)
        {
            _pagamentoRepository.Cadastrar(pagamento);



            return Created();
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Pagamento pagamento = _pagamentoRepository.BuscarPorId(id);
            if (pagamento == null)
            {
                return NotFound();
            }
            return Ok(pagamento);

        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, CadastrarPagamentosDto pagamento)
        {
            try
            {
                _pagamentoRepository.Atualizar(id, pagamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }

        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _pagamentoRepository.Deletar(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }


    }
}