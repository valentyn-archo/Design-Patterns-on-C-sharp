using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The football match (Real Madrid - Barcelona) will begin in a few minutes...\n\n");
            Bet bet = new Bet();
            bet.BetTime(0);
            bet.BetTime(1);
            bet.BetTime(44);
            bet.BetTime(45);
            bet.BetTime(90);

            Console.ReadLine();
        }
    }
}
