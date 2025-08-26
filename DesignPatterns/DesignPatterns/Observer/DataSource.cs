using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class DataSource : Subject
    {
        int value;
        public int getValue()
        {
            return value;
        }
        public void setValue(int value)
        {
            this.value = value;
            notifyObservers(); //fulfils observer design pattern as it notifies all objects that this object has changed
        }
    }
}
