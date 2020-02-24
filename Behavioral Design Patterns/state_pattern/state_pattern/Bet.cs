using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_pattern
{
    public class Bet
    {
        State currentState;

        public Bet()
        {
            this.currentState = new StartState();
        }

        public void BetTime(int minutes)
        {
            Console.WriteLine("Real Time of Match: " + minutes);
            if (minutes == 0)
                this.currentState = new StartState();
            if (minutes > 0 && minutes < 45)
                this.currentState = new FirstHalfState();
            if (minutes >= 45 && minutes < 90)
                this.currentState = new SecondHalfState();
            if (minutes >= 90)
                this.currentState = new EndState();

            currentState.ExecuteCommand(this);
        }
    }
}
