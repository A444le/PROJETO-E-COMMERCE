﻿using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace E_CommerceAPI.ServiceS
{
    public class PasswordService
    {
        //PasswordHasher - PBKDE2

        private readonly PasswordHasher<Cliente> _hasher = new();

        //Metodos  usados 
        //1 - Gerar um hash
        public string HashPassword(Cliente cliente)
        {
            return _hasher.HashPassword(cliente, cliente.Senha);
        }
        //2 - Verificar o hash 
        public bool VerificarSenha(Cliente cliente, string senhaInformada)
        {
            var resultado = _hasher.VerifyHashedPassword(cliente, cliente.Senha, senhaInformada);
            return resultado == PasswordVerificationResult.Success;

            //ou
            
            //if(resultado == PasswordVerificationResult.Success)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
        }
    }
}
