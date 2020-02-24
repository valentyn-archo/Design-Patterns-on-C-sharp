using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_pattern_bet
{
    public class Football : Bet
    {

    public void makeBet()
    {
        Console.WriteLine("You make a bet on Football");
    }
}
}
