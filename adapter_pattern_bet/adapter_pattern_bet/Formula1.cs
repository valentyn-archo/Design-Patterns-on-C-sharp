using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern_bet
{
    public class Formula1 : Bet
    {
    private int amount;
    private double coefficient;

    public Formula1(int amount, double coefficient)
    {
        this.amount = amount;
        this.coefficient = coefficient;
    }

    public int getAmount()
    {
        return amount;
    }

    public void setAmount(int amount)
    {
        this.amount = amount;
    }

    public double getCoefficient()
    {
        return coefficient;
    }

    public void setCoefficient(double coefficient)
    {
        this.coefficient = coefficient;
    }

    public double getTotalWin()
    {
        Console.WriteLine("Formula 1 bet is always adapted...");
        return coefficient * amount;
    }
}
}
