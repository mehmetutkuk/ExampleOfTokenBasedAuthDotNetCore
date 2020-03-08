using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleOfTokenBasedAuthDotNetCore
{
    public class UserManagementService
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
}
