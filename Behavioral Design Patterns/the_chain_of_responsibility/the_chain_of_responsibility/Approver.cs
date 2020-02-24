using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_chain_of_responsibility
{
    abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract void ProcessRequest(Bet bet);
    }
}
