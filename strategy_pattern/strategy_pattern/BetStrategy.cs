using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    abstract class BetStrategy
    {
        public abstract void SetTypeOfBet(BetNames betName);
    }

    enum BetNames
    {
        FOOTBALL,
        VOLLEYBALL,
        BASKETBALL
    }
}
