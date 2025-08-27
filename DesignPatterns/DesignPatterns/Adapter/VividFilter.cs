using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class VividFilter : Filter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
