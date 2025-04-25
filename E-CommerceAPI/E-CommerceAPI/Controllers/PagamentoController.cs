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
        public IActionResult CadastrarProduto(CadastrarPagamentosDto Pagamento)
        {
            _pagamentoRepository.Cadastrar(Pagamento);



            return Created();
        
        }
    }
}