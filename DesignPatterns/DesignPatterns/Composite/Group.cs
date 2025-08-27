using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Group : Component
    {
        private List<Component> components = new List<Component>();
        public void add(Shape shape)
        {
            components.Add(shape);
        }
        public void render()
        {
            foreach (var shape in components)
            {
                shape.render();
            }
        }
    }
}
