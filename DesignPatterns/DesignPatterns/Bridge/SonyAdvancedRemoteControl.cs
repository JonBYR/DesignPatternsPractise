using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turning on Sony TV.");

        }
        public override void TurnOff()
        {
            Console.WriteLine("Turning off Sony TV.");
        }
        public override void SetChannel(int number)
        {
            Console.WriteLine($"Setting Sony TV channel to {number}.");
        }
    }
}
