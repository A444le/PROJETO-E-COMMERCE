using System.IdentityModel.Tokens.Jwt;
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
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Minha-Chave-Ultra-Mega-secreta-do-Senai"));

            //Criptografando a chave de seguranca 
            var creds = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            //Montar um token 
            var token = new JwtSecurityToken(
              issuer: "ecommerce", // issuer e audience tem que ser o mesmo nome
              audience: "ecommerce",
              claims: claims, // aqui eu guardo o email
              expires: DateTime.Now.AddMinutes(30), // tempo de expiracao, aqui tem 30 minutos, mas deixar no maximo 60 minutos
              signingCredentials: creds // aqui e a senha


              );
            return new JwtSecurityTokenHandler().WriteToken(token); 
        }
    }
}
