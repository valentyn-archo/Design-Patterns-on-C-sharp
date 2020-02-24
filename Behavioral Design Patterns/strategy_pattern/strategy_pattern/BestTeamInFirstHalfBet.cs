using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    class BestTeamInFirstHalfBet : BetStrategy
    {
        public override void SetTypeOfBet(BetNames betName)
        {
            Console.WriteLine("\nBet on " + betName + " by betting on best team in the first half was created.");
        }
    }
}
