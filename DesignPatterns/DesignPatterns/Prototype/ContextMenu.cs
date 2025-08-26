using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class ContextMenu
    {
        public void duplicate(Component component)
        {
            component.clone().render();
        }
    }
}
