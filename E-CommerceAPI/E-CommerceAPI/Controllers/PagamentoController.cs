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
    public class PagamentoController : ControllerBase
    {
        private IpagamentoRepository _pagamentoRepository;
        public PagamentoController(PagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }
        
         
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(Pagamento Pagamento)
        {
            _pagamentoRepository.Cadastrar(Pagamento);

            

            return Created();
        }


    }
}
    

