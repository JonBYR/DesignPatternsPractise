using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Movie
    {
        private int duration = 3;
        
        public void addFrame(string text, int duration)
        {
            Console.WriteLine("Adding frame to movie: " + text + " with duration: " + duration + "ms");
        }
        
    }
}
