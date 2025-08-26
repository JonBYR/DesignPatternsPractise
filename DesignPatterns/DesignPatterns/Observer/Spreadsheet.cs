using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Spreadsheet : ObserverInterface
    {
        private DataSource source;
        public Spreadsheet(DataSource source)
        {
            this.source = source;
        }
        public void update()
        {
            Console.WriteLine("Spreadsheet notified" + source.getValue());
        }
    }
}
