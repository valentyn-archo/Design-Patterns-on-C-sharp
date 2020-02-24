using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            BetMaker betMaker = new BetMaker();

            betMaker.makeBetFootball();
            betMaker.makeBetChess();
            betMaker.makeBetPolitic();

            Console.ReadLine();
        }
    }
}
