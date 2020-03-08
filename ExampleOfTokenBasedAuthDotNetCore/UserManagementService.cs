using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleOfTokenBasedAuthDotNetCore
{
    public class UserManagementService : IUserManagementService
    {

        public bool IsValidUser(string userName, string password)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}
