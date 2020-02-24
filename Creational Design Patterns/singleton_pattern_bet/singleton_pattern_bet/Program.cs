using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bet bet = Bet.getInstance("percent bet", "Football", "Real Madrid", 1200);

            bet.getInfo();

            Console.ReadLine();
        }
    }
}
