using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    class BetMethod
    {
        private BetNames Name;
        private BetStrategy _betStrategy;

        public void SetCookStrategy(BetStrategy betStrategy)
        {
            this._betStrategy = betStrategy;
        }

        public void SetName(BetNames name)
        {
            Name = name;
        }

        public void SetTypeOfBet()
        {
            _betStrategy.SetTypeOfBet(Name);
            Console.WriteLine();
        }
    }
}
