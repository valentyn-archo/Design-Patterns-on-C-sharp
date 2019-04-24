using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern_bet
{
    public class CasualUser : User
    {

    protected Bet bet;

    public CasualUser() { }

    public CasualUser(Bet bet)
    {
        this.bet = bet;
    }

    public void makeBet()
    {
        Console.WriteLine("Bet was created...");
    }
}
}
