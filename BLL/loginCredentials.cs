using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class loginCredentials
    {
        static string un = "admin";
        static string pw = "password";

        public static Boolean LoginCreds(string username, string password)
        {
            if (un == username && pw == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
