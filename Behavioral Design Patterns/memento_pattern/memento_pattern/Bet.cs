using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class Bet
    {
        private TimeSpan time = new TimeSpan(10, 30, 0);
        private string name = "Football";
        private int counter = 0;
        public void BeginBet()
        {
            if (counter == 0)
            {
                counter++;
            } else
            {
                TimeSpan addtime = TimeSpan.FromMinutes(10);
                this.time = time.Add(addtime);
            }
            Console.WriteLine("Match: {0} will be at {1} today", name, time);
        }
     
        public BetMemento SaveState()
        {
            Console.WriteLine("\nSave: Match: {0} will be at {1} today\n", name, time);
            return new BetMemento(time);
        }

        public void RestoreState(BetMemento memento)
        {
            this.time = memento.Time;
            Console.WriteLine("\nTechnical problem... \nMatch: {0} will take place in the previous time at {1} today\n", name, time);
        }
    }
}
