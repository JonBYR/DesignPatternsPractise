using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation : Operation
    {
        public void apply(AnchorNode node)
        {
            Console.WriteLine("Highlight Anchor Node");
        }
        public void apply(HeadingNode node)
        {
            Console.WriteLine("Highlight Heading Node");
        }
    }
}
