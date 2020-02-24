using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern_bet
{
    public interface Bet
    {
        double availableWinAmount();
        void getInfo();
        void addCoef(double coefficient);
        double getCoefficient();
    }
}
