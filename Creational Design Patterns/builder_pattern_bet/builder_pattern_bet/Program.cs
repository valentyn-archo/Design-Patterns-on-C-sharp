using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            Bet myBet = new Bet.Builder()
                .withKind("Percent Bet")
                .withName("Football")
                .withTeam("Real Madrid")
                .withDate(DateTime.Now)
                .withAmount(2500)
                .build();
            myBet.getInfo();
            Console.ReadLine();
        }
    }
}
