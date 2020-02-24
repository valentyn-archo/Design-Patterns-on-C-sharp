using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    class BestPlayerBet : BetStrategy
    {
        public override void SetTypeOfBet(BetNames betName)
        {
            Console.WriteLine("\nBet on " + betName + " by betting on best player was created.");
        }
    }
}
