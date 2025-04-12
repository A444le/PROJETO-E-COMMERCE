using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    //ROUTE E API = ESSAS DUAS LINHAS VAO SER AS REF. PARA ACESSAR O SITE
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // ESSES CODIGOS SAO OBRIGATORIOS 
        private IClienteRepository _ClienteRepository;
        private readonly EcommerceContext _context;

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _ClienteRepository = new ClienteRepository(_context);
        } 
        //PARA APARECER NO SITE (LISTAR NO SITE)
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_ClienteRepository.ListarTodos());
        }  // Cadastrar Produto
        // Post - Cadastrar uma ou mais informacoes para o front 
        [HttpPost]
        public IActionResult CadastrarProduto(Cliente Cliente)
        {
            // 1 - Coloco o Produto no banco de dados
            _ClienteRepository.Cadastrar(Cliente);

            // 2 - Salvo a alteracao
            _context.SaveChanges(); // Sempre colocar o SaveChanges quando for mudar algo no Banco de Dados

            // 3 - Retorne um resultado
            // 201 - Created <Criado>
            return Created();
        }
    }
}

    

    

