using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model.Laptop
{
    class FabrykaPodzespolowLaptop : IFabrykaPodzespolowKomputerowych
    {
        public IDysk produkujDysk()
        {
            return new DyskDlaLaptopa();
        }

        public IGrafika produkujGrafike()
        {
            return new GrafikaDlaLaptopa();
        }

        public IRam produkujRam()
        {
            return new DDR3();
        }

        public IProcesor produkujProcesor()
        {
            return new ProcesorDlaLaptopa();
        }

        public IChlodzenie produkujChlodzenie()
        {
            return new ChlodzenieDlaLaptopa();
        }
    }
}
