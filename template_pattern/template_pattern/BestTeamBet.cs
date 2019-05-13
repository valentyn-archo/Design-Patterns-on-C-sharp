using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_pattern
{
    class BestTeamBet : Bet
    {
        public override void Calculate()
        {
            Console.WriteLine("The calculation of all winning bets on the best team...");
            Console.WriteLine("All money, that users betted was calculated!!!");
        }

        public override void ReturnCash()
        {
            Console.WriteLine("Returning cash to users, that betted on the best team...");
            Console.WriteLine("All money were send!!!\n");
        }
    }
}
