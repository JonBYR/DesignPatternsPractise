using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Server
    {
        Handler handler;
        public Server(Handler h)
        {
            handler = h;
        }
        public void handle(HttpRequest request)
        {
            handler.handle(request);
        }
    }
}
