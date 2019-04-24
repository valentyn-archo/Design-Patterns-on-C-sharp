using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            BetFactory factory = new BetFactory();

            Bet football = factory.getBet(BetTypes.FOOTBALL);
            Bet formula1 = factory.getBet(BetTypes.FORMULA1);
            Bet politic = factory.getBet(BetTypes.POLITIC);

            football.makeBet();
            formula1.makeBet();
            politic.makeBet();

            Console.ReadLine();
        }
    }
}
