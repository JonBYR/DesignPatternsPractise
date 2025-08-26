using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ProductController : Controller
    {
        public void ListProducts() //this classes uses the default factory method from Controller
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            render("products.html", data);
        }
    }
}
