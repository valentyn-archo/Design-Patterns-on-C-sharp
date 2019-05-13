using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_pattern
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
