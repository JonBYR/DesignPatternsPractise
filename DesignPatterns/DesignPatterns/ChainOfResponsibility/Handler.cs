using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }
        public abstract bool doHandle(HttpRequest request);
        public void handle(HttpRequest request)
        {
            if (doHandle(request)) return;
            if (next != null) next.handle(request);
        }
    }
}
