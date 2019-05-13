using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BetMethod betMethod = new BetMethod();
            betMethod.SetName(BetNames.FOOTBALL);

            Console.WriteLine("What kind of strategy would you like to use (1-4)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("");
            switch (input)
            {
                case 1:
                    betMethod.SetCookStrategy(new BestPlayerBet());
                    betMethod.SetTypeOfBet();
                    break;

                case 2:
                    betMethod.SetCookStrategy(new BestTeamBet());
                    betMethod.SetTypeOfBet();
                    break;

                case 3:
                    betMethod.SetCookStrategy(new BestTeamInFirstHalfBet());
                    betMethod.SetTypeOfBet();
                    break;

                case 4:
                    betMethod.SetCookStrategy(new BestTeamInSecondHalfBet());
                    betMethod.SetTypeOfBet();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
