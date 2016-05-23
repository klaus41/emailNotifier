using ActiveUp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Mail_Notifier_Logic_Layer.AgentRepository
{
    public class Notifier
    {
        private Imap4Client client = new Imap4Client();

        private int safeServerPortNumber = 993;

        private string gmailServerAddress = "imap.gmail.com";
        private string yahooServerAddress = "imap.mail.yahoo.com";
        private string outlookServerAddress = "imap-mail.outlook.com";

        private string unseenEmails = "UNSEEN";
        private Mailbox currentMailbox;
        private MessageCollection fetchedEmails;

        public void SetUpSafeConnection(string userEmail, string userPassword)
        {
            if (userEmail.Contains("@gmail"))
            {
                client.ConnectSsl(gmailServerAddress, safeServerPortNumber);
            }
            else if (userEmail.Contains("@yahoo"))
            {
                client.ConnectSsl(yahooServerAddress, safeServerPortNumber);
            }
            else if (userEmail.Contains("@live") || userEmail.Contains("@hotmail"))
            {
                client.ConnectSsl(outlookServerAddress, safeServerPortNumber);
            }

            LogUserIn(userEmail, userPassword);
        }

        public void SetUpManualConnection(string userEmail, string userPassword, string serverAddress, int portNumber, bool ssl)
        {
            if (ssl)
            {
                client.ConnectSsl(serverAddress, portNumber);
            }
            else
            {
                client.Connect(serverAddress, portNumber);
            }

            LogUserIn(userEmail, userPassword);
        }

        private void LogUserIn(string userEmail, string userPassword)
        {
            client.Login(userEmail, userPassword);
        }

        public MessageCollection GetEmails(List<string> listOfMailboxes)
        {
            fetchedEmails = new MessageCollection();

            foreach(string mailboxName in listOfMailboxes)
            {
                currentMailbox = client.SelectMailbox(mailboxName);
                foreach (Message email in currentMailbox.SearchParse(unseenEmails))
                {
                    fetchedEmails.Add(email);
                }
            }

            return fetchedEmails;
        }
    }
}
