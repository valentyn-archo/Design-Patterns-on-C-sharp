using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Bet bet = new Bet();
            bet.BeginBet();

            BetHistory betHistory = new BetHistory();

            betHistory.History.Push(bet.SaveState());
            bet.BeginBet();
            bet.BeginBet();
            bet.BeginBet();
            bet.RestoreState(betHistory.History.Pop());

            bet.BeginBet();

            Console.Read();
        }
    }
}
