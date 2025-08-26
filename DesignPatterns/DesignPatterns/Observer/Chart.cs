using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Chart : ObserverInterface
    {
        private DataSource source;
        public Chart(DataSource source)
        {
            this.source = source;
        }
        public void update()
        {
            Console.WriteLine("Chart notified" + source.getValue());
        }
    }
}
