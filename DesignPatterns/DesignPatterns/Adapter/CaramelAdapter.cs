using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class CaramelAdapter : Caramel, Filter
    {
        
        
        public void apply(Image image) //this adapater will implement filter interface in a different form
        {
            init();
            render(image);
        }

        /*
         Composite form
        private Caramel caramel;
        public CaramelAdapter(Caramel c)
        {
            caramel = c;
        }
        public void apply(Image image) //this adapater will implement filter interface in a different form
        {
            c.init();
            c.render(image);
        }
        */
    }
}
