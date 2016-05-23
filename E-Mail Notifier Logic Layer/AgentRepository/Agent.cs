using ActiveUp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_Mail_Notifier_Logic_Layer.AgentRepository
{
    public class Agent
    {
        private string agentID;
        private bool done;
        private MessageCollection emails = new MessageCollection();

        private string userEmail;
        private string userPassword;
        private List<string> listOfMailboxes;

        private Notifier notifier = new Notifier();

        private Thread thread;

        public Agent(string userEmail, string userPassword, List<string> listOfMailboxes)
        {
            this.agentID = userEmail;

            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.listOfMailboxes = listOfMailboxes;
        }

        public string ServerAddress { get; set; }

        public int PortNumber { get; set; }

        public bool Ssl { get; set; }

        public MessageCollection GetEmails()
        {
            return emails;
        }

        public void StartAgent()
        {
            done = false;

            if(ServerAddress != null && PortNumber > 0)
            {
                notifier.SetUpManualConnection(userEmail, userPassword, ServerAddress, PortNumber, Ssl);
            }
            else
            {
                notifier.SetUpSafeConnection(userEmail, userPassword);
            }

            thread = new Thread(new ThreadStart(DoWork));
            thread.Start();
        }

        private void DoWork()
        {
            while (!done)
            {
                try
                {
                    foreach (Message email in notifier.GetEmails(listOfMailboxes))
                    {
                        emails.Add(email);
                    }
                }
                catch(ThreadInterruptedException){}
            }
        }

        public void ClearMessagePool()
        {
            emails = new MessageCollection();
        }

        public void StopAgent()
        {
            done = true;
            thread.Interrupt();
        }
    }
}
