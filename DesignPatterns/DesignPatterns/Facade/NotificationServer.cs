using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class NotificationServer
    {
        public Connection connect(string ipAddress)
        {
            return new Connection();
        }
        public AuthToken auth(string appId, string key)
        {
            return new AuthToken();
        }
        public void send(AuthToken token, Message message, string target)
        {
            Console.WriteLine("Sending message");
        }
    }
}
