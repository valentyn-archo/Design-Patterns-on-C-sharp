using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class BetOnFormula1Start : Bet
    {
        public BetOnFormula1Start()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Bet on Formula 1 Started.");
        }
    }
}
