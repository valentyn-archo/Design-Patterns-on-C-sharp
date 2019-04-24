using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern_bet
{
    public class Football : Bet
    {
    private int amount;
    private String team;
    private double coefficient;

    public double availableWinAmount()
    {
        return amount * coefficient;
    }

    public Football(int amount, String team, double coefficient)
    {
        this.amount = amount;
        this.team = team;
        this.coefficient = coefficient;
    }

    public void addCoef(double coefficient)
    {
        this.coefficient += coefficient;
    }

    public double getCoefficient()
    {
        return this.coefficient;
    }

    public void getInfo()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| It`s bet on Football.");
        Console.WriteLine("| Amount on bet: " + amount + " UAH.");
        Console.WriteLine("| Current team is " + team + ".");
        Console.WriteLine("| Available win amount " + availableWinAmount() + ".");
        Console.WriteLine("------------------------------------\n");
    }

}

}
