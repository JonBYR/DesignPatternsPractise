using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class HTMLDocument
    {
        private List<HTMLNode> nodes = new List<HTMLNode>();

        public void addNode(HTMLNode node)
        {
            nodes.Add(node);
        }
        public void execute(Operation operation)
        {
            foreach (var node in nodes)
            {
                node.execute(operation);
            }
        }
    }
}
