using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{

    public class BetOnFormula1End : Bet
    {
        public BetOnFormula1End()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Bet on Formula 1 ended.");
        }
    }
}
