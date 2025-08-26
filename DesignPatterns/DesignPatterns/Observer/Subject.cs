using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Subject
    {
        List<ObserverInterface> observers = new List<ObserverInterface>();
        public void registerObserver(ObserverInterface observer)
        {
            observers.Add(observer);
        }
        public void removeObserver(ObserverInterface observer)
        {
            observers.Remove(observer);
        }
        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
    }
}
