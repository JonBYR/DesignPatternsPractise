using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class AntWidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new AntButton();
        }
        public TextBox createTextBox()
        {
            return new AntTextBox();
        }
    }
    
}
