using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class emailInfo
    {
        public static string getSubject()
        {
            string subject = "This is a header";
            return subject;
        }

        public static string getBody()
        {
            string body = "This is the Body! This is the Body! This is the Body!" +
                          "This is the Body! This is the Body! This is the Body!" +
                          "This is the Body! This is the Body! This is the Body! This is the Body! This is the Body!";
            return body;
        }

        public static string getSender()
        {
            string sender = "ivangay@fagnet.ana";
            return sender;
        }
    }
}
