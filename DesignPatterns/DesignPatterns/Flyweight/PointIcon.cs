using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class PointIcon
    {
        private PointType pointType;
        private byte[] icon;
        public PointIcon(PointType pointType, byte[] icon)
        {
            this.pointType = pointType;
            this.icon = icon;
        }
        public PointType GetType()
        {
            return pointType;
        }
    }
}
