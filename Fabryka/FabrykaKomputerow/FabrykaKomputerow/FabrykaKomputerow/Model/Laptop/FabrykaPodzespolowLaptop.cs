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
        public IDysk ProdukujDysk()
        {
            return new DyskDlaLaptopa();
        }

        public IGrafika ProdukujGrafike()
        {
            return new GrafikaDlaLaptopa();
        }

        public IRam ProdukujRam()
        {
            return new DDR3();
        }

        public IProcesor ProdukujProcesor()
        {
            return new ProcesorDlaLaptopa();
        }

        public IChlodzenie ProdukujChlodzenie()
        {
            return new ChlodzenieDlaLaptopa();
        }
    }
}
