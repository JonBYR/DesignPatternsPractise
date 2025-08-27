using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class EBookProxy : EBook
    {
        private string fileName;
        private RealEbook realEbook;
        public EBookProxy(string fileName)
        {
            this.fileName = fileName;
        }
        public string getFileName()
        {
            return fileName;
        }
        public void show()
        {
            if(realEbook == null)
            {
                realEbook = new RealEbook(fileName);
            }
            realEbook.show();
        }
    }
}
