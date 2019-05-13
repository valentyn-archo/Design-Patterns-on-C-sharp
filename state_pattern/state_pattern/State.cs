using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_pattern
{
    public interface State
    {
        void ExecuteCommand(Bet bet);
    }
    
    public class StartState : State
    {
        public void ExecuteCommand(Bet bet)
        {
            Console.WriteLine("Bets were closed. The match was begin\n");
        }
    }
 
    public class FirstHalfState : State
    {
        public void ExecuteCommand(Bet bet)
        {
            Console.WriteLine("I`s the first half of the match.\n");
        }
    }
    
    public class SecondHalfState : State
    {
        public void ExecuteCommand(Bet bet)
        {
            Console.WriteLine("I`s the second half of the match.\n");
        }
    }

    public class EndState : State
    {
        public void ExecuteCommand(Bet bet)
        {
            Console.WriteLine("Match has been finished.\n");
        }
    }
}
