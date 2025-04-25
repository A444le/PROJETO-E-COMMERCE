using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
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
        private IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        //PARA APARECER NO SITE (LISTAR NO SITE)
      
        // Post - Cadastrar uma ou mais informacoes para o front 
        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarClientesDto cliente)
        {
            // 1 - Coloco o Produto no banco de dados
            _clienteRepository.Cadastrar(cliente);

            // 2 - Salvo a alteracao


            // 3 - Retorne um resultado
            // 201 - Created <Criado>
            return Created();
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Cliente cliente = _clienteRepository.BuscarPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);

        }

        [HttpGet]
        public IActionResult Listarlientes()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, CadastrarClientesDto prod)
        {
            try
            {
                _clienteRepository.Atualizar(id, prod);
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
                _clienteRepository.Deletar(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
        [HttpGet("/buscar/{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            return Ok(_clienteRepository.BuscarClientePorNome(nome));

        }
        [HttpGet("{email}/{senha}")]
    public IActionResult login (string email, string senha)
    {
        var cliente = _clienteRepository.BuscarPorEmailSenha(email,senha);
        if (cliente == null) 
                return NotFound();  
        return Ok(cliente);


    }

    }
}