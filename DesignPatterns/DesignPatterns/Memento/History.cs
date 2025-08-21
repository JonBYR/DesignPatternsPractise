using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        List<DocumentState> states = new List<DocumentState>();
        public void push(DocumentState state)
        {
            states.Add(state);
        }
        public DocumentState pop()
        {
            var index = states.Count - 1;
            var state = states[index];
            states.RemoveAt(index);
            return state;
        }
    }
}
