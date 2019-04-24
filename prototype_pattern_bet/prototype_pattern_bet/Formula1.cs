using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_pattern_bet
{
    public class Formula1 : Bet
    {

        public String best_driver;

        public Formula1()
        {

        }

        public Formula1(Formula1 target) :
                base(target)
        {
            if ((target != null))
            {
                this.best_driver = target.best_driver;
            }

        }

        public override Bet clone()
        {
            return new Formula1(this);
        }

        public override bool Equals(Object object2)
        {
            if ((!(object2 is Formula1)
                        || !base.Equals(object2)))
            {
                return false;
            }

            Formula1 bet2 = ((Formula1)(object2));
            return (bet2.best_driver == this.best_driver);
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
                            + (amount + (",\n" + ("Best driver: "
                            + (this.best_driver + ".\n")))))))))))));
        }
    }
}
