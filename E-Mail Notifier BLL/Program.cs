using ActiveUp.Net.Mail;
using E_Mail_Notifier_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Threading;

namespace E_Mail_Notifier_BLL
{
    class Program
    {
        private static List<string> listOfMailboxes = new List<string>() { "Inbox" };

        static void Main(string[] args)
        {
            ProxyConnector pc = ProxyConnector.GetInstance();

            Console.WriteLine("Let's do this!");
            Console.WriteLine();

            pc.AgentManager.AddAndStartSafeAgent("ivan.spajic@gmail.com", "mypasswordisis131095", listOfMailboxes);
            pc.AgentManager.AddAndStartSafeAgent("math.mathson@gmail.com", "is131095", listOfMailboxes);
            pc.AgentManager.AddAndStartSafeAgent("klausgaarde@live.dk", "klaus240789", listOfMailboxes);

            while (true)
            {
                MessageCollection emails = pc.AgentManager.GetAllFetchedEmails();
                foreach(Message email in emails)
                {
                    Console.WriteLine(email.Subject);
                }
            }
        }
    }
}
