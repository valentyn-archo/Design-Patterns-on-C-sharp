using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_abstract_fabric_bet
{
    public interface BetAbstractFabric
    {
        BestPlayerBet createBestPlayerBet();
        PercentBet createPercentBet();
    }
}
