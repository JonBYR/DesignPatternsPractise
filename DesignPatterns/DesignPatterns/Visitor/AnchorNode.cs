using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class AnchorNode : HTMLNode
    {
        public void execute(Operation operation)
        {
            operation.apply(this);
        }
    }
}
