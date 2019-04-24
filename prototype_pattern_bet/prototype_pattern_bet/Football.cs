using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_pattern_bet
{
    public class Football : Bet
    {

        public String goalkeeper;

        public Football()
        {

        }

        public Football(Football target) :
                base(target)
        {
            if ((target != null))
            {
                this.goalkeeper = target.goalkeeper;
            }

        }

        public override Bet clone()
        {
            return new Football(this);
        }

        public override bool Equals(Object object2)
        {
            if ((!(object2 is Football)
                        || !base.Equals(object2)))
            {
                return false;
            }

            Football bet2 = ((Football)(object2));
            return (bet2.goalkeeper == this.goalkeeper);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void getInfo()
        {
            Console.WriteLine(("-------------------------\nBet Info\n-------------------------\n" + ("Type of bet: "
                            + (type + (",\n" + ("Team: "
                            + (team + (",\n" + ("Amount on bet: "
                            + (amount + (",\n" + ("Goalkeeper: "
                            + (this.goalkeeper + ".\n")))))))))))));
        }
    }
}
