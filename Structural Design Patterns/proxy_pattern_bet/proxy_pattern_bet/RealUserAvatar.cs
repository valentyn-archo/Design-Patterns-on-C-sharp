using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_pattern_bet
{
    public class RealUserAvatar : UserAvatar
    {

    private String fileName;

    public RealUserAvatar(String fileName)
    {
        this.fileName = fileName;
        loadFromDisk(fileName);
    }

    public void display()
    {
        Console.WriteLine("Displaying " + fileName);
    }

    private void loadFromDisk(String fileName)
    {
            Console.WriteLine("Loading " + fileName);
    }
}
}
