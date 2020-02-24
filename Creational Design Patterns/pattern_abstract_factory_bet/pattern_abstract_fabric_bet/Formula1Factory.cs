using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_abstract_fabric_bet
{
    public class Formula1Factory : BetAbstractFabric
    {
    public PercentBet createPercentBet()
    {
        return new Formula1BetPercent();
    }

    public BestPlayerBet createBestPlayerBet()
    {
        return new Formula1BetBestPlayer();
    }
}
}
