using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_abstract_fabric_bet
{
    public class Application
    {
        private PercentBet percentBet;
        private BestPlayerBet bestPlayerBet;

        public Application(BetAbstractFabric factory)
        {
            percentBet = factory.createPercentBet();
            bestPlayerBet = factory.createBestPlayerBet();
        }

        public void makeBet()
        {
            percentBet.makeBet();
            bestPlayerBet.makeBet();
        }
    }

}
