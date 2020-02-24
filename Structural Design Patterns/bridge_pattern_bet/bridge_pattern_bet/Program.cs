using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            testBet(new Football(1000, "Real Madrid", 1.84));
            testBet(new Formula1(817, "Florenco", 4.12));

            Console.ReadLine();
        }

        public static void testBet(Bet bet)
        {
            Console.WriteLine("Tests with casual user...");
            CasualUser casualUser = new CasualUser(bet);
            casualUser.makeBet();
            bet.getInfo();

            Console.WriteLine("Tests with previleged user...");
            PrevilegedUser previlegedUser = new PrevilegedUser(bet);
            Console.WriteLine("New bet coefficient is: " + previlegedUser.bonus());
            bet.getInfo();
        }
    }
}
