using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class DocumentState
    {
        private string content;
        private string fontName;
        private int fontSize;
        public DocumentState(string c, string fn, int fs)
        {
            content = c;
            fontName = fn;
            fontSize = fs;
        }
        public string getContent()
        {
            return content;
        }
        public String getFontName()
        {
            return fontName;
        }
        public int getFontSize()
        {
            return fontSize;
        }
    }
}
