using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class PointIconFactory
    {
        Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon getIcon(PointType type)
        {
            if(!icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                icons.Add(type, icon);
            }
            return icons[type];
        }
    }
}
