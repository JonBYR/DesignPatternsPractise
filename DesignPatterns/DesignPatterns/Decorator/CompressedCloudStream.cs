using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : Stream
    {
        private Stream stream;
        public CompressedCloudStream(Stream stream)
        {
            this.stream = stream;
        }
        public void write(string data)
        {
            var compressedData = Compress(data);
            stream.write(compressedData);
        }
        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
