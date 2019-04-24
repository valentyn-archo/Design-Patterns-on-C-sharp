using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_pattern_bet
{
    public class CompositeDemo
    {

        public static StringBuilder compositeBuilder = new StringBuilder();
        static void Main(string[] args)
        {
            User user1 = new User("Valik");
            User user2 = new User("Maks");
            User user3 = new User("Andrew");

            Bet bet1 = new Bet("percent bet", "Football", "Real Madrid", 1200);
            Bet bet2 = new Bet("percent bet", "Football", "Real Madrid", 450);
            Bet bet3 = new Bet("percent bet", "Football", "Real Madrid", 470);
            Bet bet4 = new Bet("player bet", "Football", "FC Barselona", 800);
            Bet bet5 = new Bet("percent bet", "Volleyball", "Ultava", 215);
            Bet bet6 = new Bet("player bet", "Volleyball", "Gordonia", 850);
            Bet bet7 = new Bet("player bet", "Volleyball", "Mavichia", 610);

            user1.add(bet1);
            user1.add(bet2);
            user1.add(bet3);
            user2.add(bet4);
            user2.add(bet5);
            user3.add(bet6);
            user3.add(bet7);

            user1.ls();
            user2.ls();
            user3.ls();

            Console.ReadLine();
        }
    }
}
