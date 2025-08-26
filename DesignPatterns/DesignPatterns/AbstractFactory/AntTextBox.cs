using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class AntTextBox : TextBox
    {
        public void render()
        {
            Console.WriteLine("Rendering Ant TextBox");
        }
    }
}
