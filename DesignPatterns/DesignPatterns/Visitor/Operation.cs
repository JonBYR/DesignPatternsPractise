using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface Operation
    {
        void apply(AnchorNode node);
        void apply(HeadingNode node);  
    }
}
