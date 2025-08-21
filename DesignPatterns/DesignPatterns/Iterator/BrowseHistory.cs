using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();
        public void Push(string url)
        {
            urls.Add(url);
        }
        public string Pop()
        {
            int index = urls.Count - 1;
            string lastUrl = urls[index];
            urls.RemoveAt(index);
            return lastUrl;
        }
        public Iteartor<string> createIterator()
        {
            return new ListIterator(this);
            //pass through this which is reference to the current instance of BrowseHistory
        }
        //use a nested class so that we can access the private members of BrowseHistory
        public class ListIterator : Iteartor<string>
        {
            private BrowseHistory history;
            private int index;
            public ListIterator(BrowseHistory history)
            {
                this.history = history;
                this.index = 0;
            }
            public bool HasNext()
            {
                return index < history.urls.Count;
            }
            public string Current()
            {
                return history.urls[index];
            }
            public void Next()
            {
                index++;
            }
        }
    }
}
