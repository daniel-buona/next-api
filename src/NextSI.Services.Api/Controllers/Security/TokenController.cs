using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NextSI.Services.Api.Configurations;
using System;
using System.Security.Claims;
using System.Security.Principal;
using System.IdentityModel.Tokens.Jwt;

namespace NextSI.Services.Api.Controllers.Security
{
    public class TokenController : ApiController
    {

        private TokenConfigurations _tokenConfigurations;
        private SigningConfigurations _signingConfigurations;

        public TokenController(TokenConfigurations tokenConfigurations,
                               SigningConfigurations signingConfigurations)
        {
            _tokenConfigurations = tokenConfigurations;
            _signingConfigurations = signingConfigurations;
        }

        [HttpGet]
        [Route("Token/{UserName}/{Password}")]
        public object Get(string UserName, string Password)
        {
            UserAccess User = new UserAccess() { UserName = UserName, Password = Password };
            if (User.UserName != null && User.UserName == User.Password)
            {
                return GenerateToken(User);
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Authenticate failed"
                };
            }

        }

        private object GenerateToken(UserAccess User)
        {
            ClaimsIdentity identity = new ClaimsIdentity(
                                new GenericIdentity(User.UserName, "UserName"),
                                new[] {
                                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                                        new Claim(JwtRegisteredClaimNames.UniqueName, User.UserName),
                                        new Claim(ClaimTypes.Role, User.UserName)
                                }
                            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao +
                TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao,
            });
            var token = handler.WriteToken(securityToken);

            return new
            {
                authenticated = true,
                created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                message = "OK"
            };
        }
    }
}