using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_pattern_bet
{
    public class BetFactory
    {

        public Bet getBet(BetTypes type)
        {
            Bet toReturn = null;
            switch (type)
            {
                case BetTypes.POLITIC:
                    toReturn = new Politic();
                    break;
                case BetTypes.FOOTBALL:
                    toReturn = new Football();
                    break;
                case BetTypes.FORMULA1:
                    toReturn = new Formula1();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Wrong bet type:" + type);
            }
            return toReturn;
        }

    }
}
