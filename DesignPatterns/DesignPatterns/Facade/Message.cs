using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Message
    {
        private string text;
        public Message(string text)
        {
            this.text = text;
        }
    }
}
