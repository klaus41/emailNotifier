using ActiveUp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Mail_Notifier_Logic_Layer.AgentRepository
{
    public class AgentManager
    {
        private Dictionary<string, Agent> collectionOfAgents = new Dictionary<string, Agent>();

        private MessageCollection allEmails;

        public void AddAndStartManualAgent(string userEmail, string userPassword, List<string> listOfMailboxes, string serverAddress, int portNumber, bool ssl)
        {
            if (!collectionOfAgents.ContainsKey(userEmail))
            {
                collectionOfAgents[userEmail] = new Agent(userEmail, userPassword, listOfMailboxes) { ServerAddress = serverAddress, PortNumber = portNumber, Ssl = ssl };
                collectionOfAgents[userEmail].StartAgent();
            }
        }

        public void AddAndStartSafeAgent(string userEmail, string userPassword, List<string> listOfMailboxes)
        {
            if (!collectionOfAgents.ContainsKey(userEmail))
            {
                collectionOfAgents[userEmail] = new Agent(userEmail, userPassword, listOfMailboxes);
                collectionOfAgents[userEmail].StartAgent();
            }
        }

        public void StopAndRemoveAgent(string agentID)
        {
            if (collectionOfAgents.ContainsKey(agentID))
            {
                collectionOfAgents[agentID].StopAgent();
                collectionOfAgents.Remove(agentID);
            }
        }

        public MessageCollection GetAllFetchedEmails()
        {
            allEmails = new MessageCollection();
            
            foreach(KeyValuePair<string, Agent> agent in collectionOfAgents)
            {
                foreach(Message email in agent.Value.GetEmails())
                {
                    allEmails.Add(email);
                }

                agent.Value.ClearMessagePool();
            }

            return allEmails;
        }
    }
}
