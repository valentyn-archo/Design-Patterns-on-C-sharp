using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_chain_of_responsibility
{
    class Admin : Approver
    {
        public override void ProcessRequest(Bet bet)
        {
            if (bet.Amount < 100000)
            {
                Console.WriteLine("{0} approved purchase request on {1}",
                    this.GetType().Name, bet.Name, "\n");
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(bet);
            }
        }
    }
}
