using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace ExampleOfTokenBasedAuthDotNetCore
{
    public class TokenAuthenticationService
    {


        public bool IsAuthenticated(TokenRequest request, out string token)
        {
            token = string.Empty;
            return false;
        }
    }

    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}
