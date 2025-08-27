using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : Stream
    {
        public Stream stream;
        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }
        public void write(string data)
        {
            var encryptedData = Encrypt(data);
            stream.write(encryptedData);
        }
        private string Encrypt(string data)
        {
            return "Encrypted(" + data + ")";
        }
    }
}
