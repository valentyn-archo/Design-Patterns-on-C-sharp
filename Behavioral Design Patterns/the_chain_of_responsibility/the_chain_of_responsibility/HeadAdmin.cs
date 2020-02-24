using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_chain_of_responsibility
{
    class HeadAdmin : Approver
    {
        public override void ProcessRequest(Bet bet)
        {
            if (bet.Amount < 1000000)
            {
                Console.WriteLine("{0} approved purchase request on {1}",
                    this.GetType().Name, bet.Name, "\n");
            }
            else
            {
                Console.WriteLine(
                    "Bet request #{0} requires an executive meeting!\n\n",
                    bet.Type);
            }
        }
    }
}
