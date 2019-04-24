using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_abstract_fabric_bet
{
    public class FootballFactory : BetAbstractFabric
    {
        public PercentBet createPercentBet()
        {
            return new FootballBetPercent();
        }

        public BestPlayerBet createBestPlayerBet()
        {
            return new FootballBetBestPlayer();
        }
    }
}
