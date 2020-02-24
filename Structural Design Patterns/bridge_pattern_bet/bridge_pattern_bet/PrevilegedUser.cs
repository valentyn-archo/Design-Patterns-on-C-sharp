using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern_bet
{
    public class PrevilegedUser : CasualUser
    {
    public PrevilegedUser(Bet bet)
    {
        base.bet = bet;
    }

    public double bonus()
    {
        bet.addCoef(0.14);
        return bet.getCoefficient();
    }
}

}
