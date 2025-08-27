using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private Dictionary<string, EBook> ebooks = new Dictionary<string, EBook>();
        public void add(EBook ebook)
        {
            ebooks[ebook.getFileName()] = ebook;
        }
        public void open(string filename)
        {
            if(ebooks.ContainsKey(filename))
            {
                ebooks[filename].show();
            }
        }
    }
}
