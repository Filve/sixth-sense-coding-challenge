using Microsoft.Extensions.Configuration;

namespace sixth.sense.api.Extentions
{
    public class AuthenticationExtention : Startup
    {
        public AuthenticationExtention(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
