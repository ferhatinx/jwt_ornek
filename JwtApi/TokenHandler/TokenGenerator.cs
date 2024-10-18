using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace JwtApi.TokenHandler;

public class TokenGenerator
{
    public string GenerateToken()
    {

        SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("gfjh3kjdhfkj3hfkj3hfjk3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hf"));

        SigningCredentials signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);


        JwtSecurityToken securityToken = new JwtSecurityToken(
            issuer:"http://localhost",
            audience:"http://localhost",
            claims:null,
            notBefore:DateTime.Now,
            expires:DateTime.Now.AddMinutes(1),
            signingCredentials:signingCredentials

        );

        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        return handler.WriteToken(securityToken);
    }
}
