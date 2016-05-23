using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class emailInfo
    {
        public static string getHeader()
        {
            string header = "This is a header";
            return header;
        }

        public static string getBody()
        {
            string body = "This is the Body! This is the Body! This is the Body!" +
                          "This is the Body! This is the Body! This is the Body!" +
                          "This is the Body! This is the Body! This is the Body! This is the Body! This is the Body!";
            return body;
        }
    }
}
