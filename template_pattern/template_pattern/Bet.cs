using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_pattern
{
    abstract class Bet
    {
        public abstract void Calculate();

        public abstract void ReturnCash();

        public virtual void EndBet()
        {
            Console.WriteLine(GetType().Name + " was ended!\n");
        }

        public void MakeBet()
        {
            EndBet();
            Calculate();
            ReturnCash();
        }
    }
}
