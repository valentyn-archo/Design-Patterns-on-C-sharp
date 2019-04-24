using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_pattern_bet
{
    public abstract class Bet
    {
        public String type; //percent or best player
        public int amount;
        public String team;

        public Bet()
        {
        }

        public Bet(Bet target)
        {
            if (target != null)
            {
                this.type = target.type;
                this.amount = target.amount;
                this.team = target.team;
            }
        }

        public abstract Bet clone();

        public Boolean equals(Object object2)
        {
            if (!(object2 is Bet))
            {
                return false;
            }

            Bet bet2 = ((Bet)(object2));
            return ((bet2.type == type)
                        && ((bet2.amount == amount)
                        && Object.Equals(bet2.team, team)));
        }
    }
}
