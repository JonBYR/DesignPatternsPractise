using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Slide
    {
        private string text;
        public Slide(string text)
        {
            this.text = text;
        }
        public string getText()
        {
            return text;
        }
        public void setText(string text)
        {
            this.text = text;
        } 
    }
}
