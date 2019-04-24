using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern_bet
{
    public class Football : Bet
    {
    private int amount;
    private double percent;

    public Football(int amount, double percent)
    {
        this.amount = amount;
        this.percent = percent;
    }

    public int getAmount()
    {
        return amount;
    }

    public void setAmount(int amount)
    {
        this.amount = amount;
    }

    public double getPercent()
    {
        return percent;
    }

    public void setPercent(double percent)
    {
        this.percent = percent;
    }

    public double getTotalWin()
    {
        Console.WriteLine("Football bet is not adapted...");
        return 0.0;
    }
}
}
