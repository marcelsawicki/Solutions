using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model.Laptop
{
    class ChlodzenieDlaLaptopa : IChlodzenie
    {
        private string name = "Chlodzenie dla laptopa";

        public IChlodzenie dostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaLaptopa();
        }
    }
}
