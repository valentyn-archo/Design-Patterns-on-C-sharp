using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_pattern_bet
{
    public class ProxyUserAvatar : UserAvatar
    {
    private RealUserAvatar realUserAvatar;
    private String fileName;

    public ProxyUserAvatar(String fileName)
    {
        this.fileName = fileName;
    }

    public void display()
    {
        if (realUserAvatar == null)
        {
            realUserAvatar = new RealUserAvatar(fileName);
        }
        realUserAvatar.display();
    }
}
}
