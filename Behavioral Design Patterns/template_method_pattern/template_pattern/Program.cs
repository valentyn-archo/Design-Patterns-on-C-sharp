using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BestPlayerBet bestPlayerBet = new BestPlayerBet();
            bestPlayerBet.MakeBet();

            BestTeamBet bestTeamBet = new BestTeamBet();
            bestTeamBet.MakeBet();
         
            Console.ReadKey();
        }
    }
}
