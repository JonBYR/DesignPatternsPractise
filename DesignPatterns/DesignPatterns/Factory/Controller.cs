using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Controller
    {
      
        public void render(string viewName, Dictionary<string, object> data)
        {
            var engine = createNewView(); //child classes will call their own version of this method
            var html = engine.render(viewName, data);
            Console.WriteLine(html);
        }
        protected virtual ViewEngine createNewView() //this is the factory method that will be overridden in subclasses
        {
           return new MatchaViewEngine();
        }
    }
}
