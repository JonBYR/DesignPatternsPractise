using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ContactForm
    {
        public void render(Theme theme)
        {
            if (theme == Theme.MATERIAL)
            {
                MaterialWidgetFactory factory = new MaterialWidgetFactory();
                factory.createButton().render();
                factory.createTextBox().render();
            }
            else if (theme == Theme.ANT)
            {
                AntWidgetFactory factory = new AntWidgetFactory();
                factory.createButton().render();
                factory.createTextBox().render();
            }
        }
    }
}
