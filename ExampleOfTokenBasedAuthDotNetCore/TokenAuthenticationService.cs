using ExampleOfTokenBasedAuthDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExampleOfTokenBasedAuthDotNetCore
{
    public class TokenAuthenticationService
    {


        public bool IsAuthenticated(TokenRequest request, out string token)
        {

            token = string.Empty;
            if (!_userManagementService.IsValidUser(request.Username, request.Password)) return false;

            var claim = new[]
            {
                new Claim(ClaimTypes.Name, request.Username)
            };

            return false;
        }
    }

    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}
