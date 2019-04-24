using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight_pattern_bet
{
    public class BetImpl : Bet
    {
    private String type;
    private String name;
    private int amount;

    public BetImpl(String name)
    {
        this.name = name;
    }

    public void setType(String type)
    {
        this.type = type;
    }

    public void setAmount(int amount)
    {
        this.amount = amount;
    }

    public void makeBet()
    {
        Console.WriteLine("Bet was created...\n");
        Console.WriteLine("Bet Info: " + "Name: " + name + ", " + "type: " + type + ", "
                + "amount: " + amount + ".\n");
    }
}
}
