using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Document
    {
        private string content;
        private string fontName;
        private int fontSize;
        public Document(string c, string fn, int fs)
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
        public void setContent(string c)
        {
            content = c;
        }
        public void setFontName(string fn)
        {
            fontName = fn;
        }
        public void setFontSize(int fs)
        {
            fontSize = fs;
        }
        public void undo(DocumentState state)
        {
            content = state.getContent();
            fontName = state.getFontName();
            fontSize = state.getFontSize();
        }
    }
}
