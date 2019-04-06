using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model.PC
{
    class ChlodzenieDlaPC : IChlodzenie
    {
        private string name = "Chlodzenie dla PC";

        public IChlodzenie dostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaPC();
        }
    }
}
