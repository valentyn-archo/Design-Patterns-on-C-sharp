using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern_bet
{
    public class FootballAdapterImpl : FootballAdapter
    {
    private Football football;

    public FootballAdapterImpl(Football football)
    {
        this.football = football;
    }

    public double getTotalWin()
    {
        double percent = football.getPercent();
        return convertToCoefficient(percent) * football.getAmount();
    }

    private double convertToCoefficient(double percent)
    {
        Console.WriteLine("Football bet is now adapted...");
        return percent / 100;
    }
}
}
