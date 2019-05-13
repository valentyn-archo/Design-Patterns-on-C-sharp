using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class Bet
    {
        private String kind;
        private String name;
        private String team;
        private DateTime date_of_bet;
        private int cash;
        private HashSet<Bet> parents;

        public class Builder
        {
            private Bet newBet;

            public Builder()
            {
                newBet = new Bet();
            }

            public Builder withKind(String kind)
            {
                newBet.kind = kind;
                return this;
            }

            public Builder withName(String name)
            {
                newBet.name = name;
                return this;
            }

            public Builder withTeam(String team)
            {
                newBet.team = team;
                return this;
            }

            public Builder withDate(DateTime date_of_bet)
            {
                newBet.date_of_bet = date_of_bet;
                return this;
            }

            public Builder withAmount(int cash)
            {
                newBet.cash = cash;
                return this;
            }

            public Builder withParents(HashSet<Bet> parents)
            {
                newBet.parents = parents;
                return this;
            }

            public Bet build()
            {
                return newBet;
            }
        }

        public void getInfo()
        {
            Console.WriteLine("-------------------------\nBet Info\n-------------------------\n" + "Kind of bet: " + kind + ",\n"
                    + "Name of bet: " + name + ",\n" + "Team: " + team + ",\n"
                    + "Date of bet: " + date_of_bet + ",\n" + "Amount on bet: " + cash + ".\n");
        }
    }
}
