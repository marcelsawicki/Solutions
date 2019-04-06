using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class DDR2 : IRam
    {
        private string name = "DDR2";

        public IRam DostarczRam()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DDR2();
        }
    }
}
