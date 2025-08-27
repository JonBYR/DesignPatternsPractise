using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class NotifcationService
    {
        public void send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.connect("ipAddress");
            var authToken = server.auth("appId", "key");
            server.send(authToken, new Message(message), target);
        }
    }
}
