using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class DyskDlaLaptopa : IDysk
    {
        private string name = "Dysk dla laptopa";

        public IDysk DostarczDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaLaptopa();
        }
    }
}
