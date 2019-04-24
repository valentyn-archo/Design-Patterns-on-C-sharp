using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bet football = new Football();

            Bet bonusCoefficientFootballBet = new BonusCoefficientBetDecorator(new Football());

            Bet bonusCoefficientChessBet = new BonusCoefficientBetDecorator(new Chess());
            Console.WriteLine("Casual football bet: ");
            football.makeBet();

            Console.WriteLine("\nFootball bet with bonus coefficient: ");
            bonusCoefficientFootballBet.makeBet();

            Console.WriteLine("\nChess bet with bonus coefficient: ");
            bonusCoefficientChessBet.makeBet();

            Console.ReadLine();
        }
    }
}
