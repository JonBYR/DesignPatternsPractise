using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string username;
        private string password;
        public HttpRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
