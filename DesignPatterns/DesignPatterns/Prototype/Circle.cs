using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Circle : Component
    {
        private int radius;
        public void render()
        {
            Console.WriteLine("Rendering Circle");
        }
        public Component clone() //clone allows for the prototype pattern to exist
        {
            Circle clone = new Circle();
            clone.setRadius(radius);
            return clone;
        }
        public int getRadius()
        {
            return radius;
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
    }
}
