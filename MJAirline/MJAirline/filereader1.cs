using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJAirline
{
    class filleReader1
    {
        public string ReadFile(string filename)
        {
            string documentContent = System.IO.File.ReadAllText(filename);
            return documentContent;
        }
    }
}