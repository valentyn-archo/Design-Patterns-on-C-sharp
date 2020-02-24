using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_pattern_bet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bet> bets = new List<Bet>();
            List<Bet> betsCopy = new List<Bet>();

            Football football = new Football();
            football.type = "percent bet";
            football.amount = 200;
            football.goalkeeper = "Muller";
            football.team = "Schachtar";
            football.getInfo();
            bets.Add(football);

            Football anotherFootball = (Football)football.clone();
            anotherFootball.getInfo();
            betsCopy.Add(anotherFootball);

            Formula1 formula1 = new Formula1();
            formula1.best_driver = "Michael Schumacher";
            formula1.type = "on best driver";
            formula1.team = "Janbo";
            formula1.amount = 2500;
            formula1.getInfo();
            bets.Add(formula1);

            Formula1 anotherFormula1 = (Formula1)formula1.clone();
            anotherFormula1.getInfo();
            betsCopy.Add(anotherFormula1);

            football.amount = 500;
            football.goalkeeper = "Konoplyk";
            football.getInfo();
            anotherFootball.getInfo();

            cloneAndCompare(bets, betsCopy);

            Console.ReadLine();
        }

        private static void cloneAndCompare(List<Bet> bets, List<Bet> betsCopy)
        {
            foreach (Bet bet in bets)
            {
                betsCopy.Add(bet.clone());
            }

            for (int i = 0; i < bets.Count; i++)
            {
                if (bets[i] != betsCopy[i])
                {
                    Console.WriteLine(i + ": Bets are different objects...");
                    if (bets[i].equals(betsCopy[i]))
                    {
                        Console.WriteLine(i + ": And they are identical...");
                    }
                    else
                    {
                        Console.WriteLine(i + ": But they are not identical...");
                    }
                }
                else
                {
                    Console.WriteLine(i + ": Bet objects are the same...");
                }
            }
        }
    }
}
