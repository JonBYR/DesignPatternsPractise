using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class MaterialWidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new MaterialButton();
        }
        public TextBox createTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
