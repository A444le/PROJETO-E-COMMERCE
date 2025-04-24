using System.Linq.Expressions;
using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        //Injecao de dependencia = Ao inves de Eu instanciar a classe eu aviso que dependendo dela
        //E a responsabilidade de criar vem pra classe que chama (C#)
        public ProdutoController(IProdutoRepository produtoRepository)
        {

            _produtoRepository = produtoRepository;
        }
        //DTO
        [HttpGet]
        public IActionResult ListarProduto()
        {
            return Ok(_produtoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarProdutoDto produto)
        {
            _produtoRepository.Cadastrar(produto);
            return Created ();
        }
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Produto produto = _produtoRepository.BuscarPorId(id);
            if(produto == null)
            {
                return NotFound();
            }
            return Ok(produto); 

        }
       
        [HttpPut("{id}")]
        public IActionResult Editar(int id, CadastrarProdutoDto prod)
        {
            try
            {
                _produtoRepository.Atualizar(id, prod);
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
               _produtoRepository.Deletar(id);
                return NoContent();
            }

            catch  (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
    }
}
