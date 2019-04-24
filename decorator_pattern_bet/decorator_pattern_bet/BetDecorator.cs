using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_pattern_bet
{
    public abstract class BetDecorator : Bet
    {
    protected Bet decoratedBet;

    public BetDecorator(Bet decoratedBet)
    {
        this.decoratedBet = decoratedBet;
    }

    public virtual void makeBet()
    {
        decoratedBet.makeBet();
    }
}
}
