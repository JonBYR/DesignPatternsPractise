using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class AddCustomerCommand : CommandInterface
    {
        private CustomerService service;
        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }
        public void execute()
        {
            //service object contains command interface that delegates the work
            service.addCustomer();
            //button would be assigned an object that implements CommandInterface
        }
    }
}
