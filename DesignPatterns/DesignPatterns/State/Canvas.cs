using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    
    public class Canvas
    {
        private Tool tool;
        public Canvas(Tool t)
        {
            tool = t;
        }
        public void MouseDown()
        {
            tool.MouseDown();
        }
        public void MouseUp()
        {
            tool.MouseUp();
        }
        public Tool getTool()
        {
            return tool;
        }
        public void setTool(Tool t)
        {
            tool = t;
        }
    }
}
