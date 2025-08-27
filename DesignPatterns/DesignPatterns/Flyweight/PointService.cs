using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class PointService
    {
        public List<Point> points = new List<Point>();
        private PointIconFactory iconFactory = new PointIconFactory();

        public PointService(PointIconFactory fact)
        {
            iconFactory = fact;
        }
        public List<Point> getPoints()
        {
            Point p = new Point(1, 2, iconFactory.getIcon(PointType.CAFE));
            points.Add(p);
            return points;
        }
    }
}
