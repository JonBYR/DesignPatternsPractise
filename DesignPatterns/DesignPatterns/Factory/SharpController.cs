using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class SharpController : Controller
    {
        protected override ViewEngine createNewView() //overriding the factory method to return a different view engine
        {
            return new SharpViewEngine();
        }
    }
}
