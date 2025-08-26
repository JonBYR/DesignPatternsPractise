using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next) { }
        public override bool doHandle(HttpRequest request)
        {
            log(request);
            return true;
            //this indicates that the request has been fully handled and the chain can stop
        }
        public void log(HttpRequest request)
        {
            Console.WriteLine("Logging request...");
        }
    }
}
