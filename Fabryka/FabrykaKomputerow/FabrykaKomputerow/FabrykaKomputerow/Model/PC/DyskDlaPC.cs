using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class DyskDlaPC : IDysk
    {
        private string name = "Dysk dla PC";

        public IDysk dostarczDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaPC();
        }
    }
}
