using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_pattern
{
    public class BetOnFootballStart : Bet
    {
        public BetOnFootballStart()
        {
        }
        public void Execute()
        {
            Console.WriteLine("Bet on Football Started.");
        }
    }
}
