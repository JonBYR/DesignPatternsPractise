using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Shape : Component
    {
        public void render()
        {
            Console.WriteLine("Render shape");
        }
    }
}
