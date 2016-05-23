using E_Mail_Notifier_Logic_Layer.AgentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Mail_Notifier_Logic_Layer
{
    public class ProxyConnector
    {
        private static ProxyConnector pc = null;

        private AgentManager am;

        public static ProxyConnector GetInstance()
        {
            if(pc == null)
            {
                pc = new ProxyConnector();
            }

            return pc;
        }

        private ProxyConnector()
        {
            am = null;
        }

        public AgentManager AgentManager
        {
            get
            {
                if(am == null)
                {
                    am = new AgentManager();
                }

                return am;
            }
        }
    }
}
