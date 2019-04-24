using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight_pattern_bet
{
    public class BetFactory
    {
        public static Hashtable betTable = new Hashtable();

        public static Bet getBet(String name)
        {
            BetImpl bet = (BetImpl)betTable[name];

            if (bet == null)
            {
                bet = new BetImpl(name);
                betTable.Add(name, bet);
                Console.WriteLine("Creating bet name: " + name);
            }
            return bet;
        }
    }
}
