using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_pattern_bet
{
    public class Bet
    {
        private String type;
        private String name;
        private String team;
        private int amount;

        public Bet(String type, String name, String team, int amount)
        {
            this.type = type;
            this.name = name;
            this.team = team;
            this.amount = amount;
        }

        public void ls()
        {
            Console.WriteLine(CompositeDemo.compositeBuilder + "Name: " + name + ", " + "type: " + type + ", " + "team: " + team + ", "
            + "amount: " + amount + ".\n");
        }
    }
}
