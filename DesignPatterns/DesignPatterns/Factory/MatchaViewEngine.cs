using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class MatchaViewEngine : ViewEngine
    {
        public string render(string viewName, Dictionary<string, object> data)
        {
            return "View rendered by matcha";
        }
    }
}
