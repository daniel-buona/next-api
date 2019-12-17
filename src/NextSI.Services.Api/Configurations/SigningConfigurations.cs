using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace NextSI.Services.Api.Configurations
{
    public class SigningConfigurations
    {
        public SigningCredentials SigningCredentials { get; }

        private const string SECRET_KEY = "NextSI@2019@Secret@Key@For@WebToken@Valid@String";
        public readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public SigningConfigurations()
        {
            SigningCredentials = new SigningCredentials(
                SIGNING_KEY, SecurityAlgorithms.HmacSha256);
        }
    }
}
