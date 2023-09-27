using Core.Entities.Identity;
using Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class TokenRepository : ITokenRepository
    {
        private readonly IConfiguration configuration;

        public TokenRepository(IConfiguration configuration) {
            this.configuration = configuration;
        }
        public string CreateJWTToken(User user, Role Role,int Time)
        {
            var Claims = new List<Claim>();

            Claims.Add(new Claim(ClaimTypes.Name, user.Email));
            Claims.Add(new Claim(ClaimTypes.Role, Role.Name));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:Key"]));
            var Credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var Token = new JwtSecurityToken(
               configuration["jwt:Issure"],
               configuration["jwt:Audience"],
               Claims,
               expires: DateTime.Now.AddMinutes(Time),
               signingCredentials: Credentials);

            return new JwtSecurityTokenHandler().WriteToken(Token);
        }
    }
}
