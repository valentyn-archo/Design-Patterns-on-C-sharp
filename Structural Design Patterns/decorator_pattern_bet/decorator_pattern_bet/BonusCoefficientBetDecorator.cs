using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_pattern_bet
{
    public class BonusCoefficientBetDecorator : BetDecorator
    {

        public BonusCoefficientBetDecorator(Bet decoratedBet) :
            base(decoratedBet)
        {
            
        }
        public override void makeBet()
        {
            decoratedBet.makeBet();
            Console.WriteLine("System add 0.14 for your coefficient!!!");
        }
    }
}
