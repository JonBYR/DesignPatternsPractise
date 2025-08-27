using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class SonyTV : Device
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on Sony TV.");

        }
        public void TurnOff()
        {
            Console.WriteLine("Turning off Sony TV.");
        }
        public void SetChannel(int number)
        {
            Console.WriteLine($"Setting Sony TV channel to {number}.");
        }
    }
}
