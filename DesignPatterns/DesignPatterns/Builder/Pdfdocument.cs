using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Pdfdocument
    {
       
        public void addPage(string text)
        {
            Console.WriteLine("Adding page to PDF document: " + text);
        }
        
    }
}
