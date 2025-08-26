using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next) { }
        public override bool doHandle(HttpRequest request)
        {
            
            return !authenticate(request); //if authentication does not fail, return false to continue chain of command
        }
        public bool authenticate(HttpRequest request)
        {
            Console.WriteLine("Authenticating request...");
            var isValid = request.getUsername() == "admin" && request.getPassword() == "password";
            return isValid;
        }
    }
}
