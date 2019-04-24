using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bet bet1 = new Football(1000, 150);
            Console.WriteLine(bet1.getTotalWin());
            Bet bet2 = new Formula1(1000, 0.84);
            Console.WriteLine(bet2.getTotalWin());
            FootballAdapter footballAdapter = new FootballAdapterImpl((Football)bet1);
            Console.WriteLine(footballAdapter.getTotalWin());

            Console.ReadLine();
        }
    }
}
