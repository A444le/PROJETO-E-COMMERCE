using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace E_CommerceAPI.Services
{
    public class TokenService
    {
        public string GenerateToken(string email )
        {
            //Claims - Informacoes do Usuario que quero guardar
            var claims = new[]
            {
                  new Claim(ClaimTypes.Email, email),
            };
            //Criar uma chave de seguranca e criptografar ela 
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Minha-Chave-secreta-Senai"));
        }
    }
}
