using ExampleOfTokenBasedAuthDotNetCore.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExampleOfTokenBasedAuthDotNetCore
{
    public class TokenAuthenticationService : IAuthenticateService
    {
        private readonly IUserManagementService _userManagementService;
        private readonly TokenManagement _tokenManagement;

        public TokenAuthenticationService(IUserManagementService service, IOptions<TokenManagement> tokenManagement)
        {
            _userManagementService = service;
            _tokenManagement = tokenManagement.Value;
        }

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
