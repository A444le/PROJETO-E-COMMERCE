﻿using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _ClienteRepository;
        private readonly EcommerceContext _context;

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _ClienteRepository = new ClienteRepository(_context);
        }
        
    }
}
    

