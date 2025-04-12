﻿using E_CommerceAPI.Context;
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
        private IpagamentoRepository _PagamentoRepository;
        private readonly EcommerceContext _context;

        public PagamentoController(EcommerceContext context)
        {
            _context = context;
            _PagamentoRepository = new PagamentoRepository(_context);
        }
        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(_PagamentoRepository.ListarTodos());
        }
        [HttpPost]
        public IActionResult CadastrarProduto(Pagamento Pagamento)
        {
            _PagamentoRepository.Cadastrar(Pagamento);

            _context.SaveChanges();

            return Created();
        }


    }
}
    

