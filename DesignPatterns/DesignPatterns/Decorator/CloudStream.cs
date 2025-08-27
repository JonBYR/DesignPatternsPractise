using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CloudStream : Stream
    {
        public void write(string data)
        {
            Console.WriteLine("Writing data to the cloud: " + data);
        }
    }
}
