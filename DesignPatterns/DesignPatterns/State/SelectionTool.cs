using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SelectionTool : Tool
    {
        public override void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }
        public override void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
        
}
