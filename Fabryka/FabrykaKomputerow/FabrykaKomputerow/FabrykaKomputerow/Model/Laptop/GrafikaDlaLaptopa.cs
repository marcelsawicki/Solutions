using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class GrafikaDlaLaptopa : IGrafika
    {
        private string name = "Grafika dla laptopa";

        public IGrafika dostarczGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaLaptopa();
        }
    }
}
