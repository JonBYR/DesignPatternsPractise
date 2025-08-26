using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    
    public class Button
    {
        private string Label;
        private CommandInterface command;
        public Button(CommandInterface inter) {
              this.command = inter;
        }
        public void Click()
        {
            //work is delegated to another object
            command.execute();
        }
        public string getLabel()
        {
            return Label;
        }
        public void setLabel(string label)
        {
            Label = label;
        }
    }
}
