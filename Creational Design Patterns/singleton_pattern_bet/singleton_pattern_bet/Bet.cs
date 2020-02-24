using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern_bet
{
    public class Bet
    {
        private static Bet instance;
        public String type;
        public String name;
        public String team;
        public int amount;

        private Bet(String type, String name, String team, int amount)
        {
            this.type = type;
            this.name = name;
            this.team = team;
            this.amount = amount;
        }

        public static Bet getInstance(String type, String name, String team, int amount)
        {
            if (instance == null)
            {
                instance = new Bet(type, name, team, amount);
            }
            return instance;
        }

        public void getInfo()
        {
            Console.WriteLine("-------------------------\nBet Info\n-------------------------\n" + "Type of bet: " + type + ",\n"
                    + "Name of bet: " + name + ",\n" + "Team: " + team + ",\n"
                    + "Amount on bet: " + amount + ".\n");
        }
    }

}
