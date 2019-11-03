using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.Laptop
{
    class FabrykaPodzespolowLaptop : IComponentsFactory
    {
        public IDrive ProdukujDysk()
        {
            return new DyskDlaLaptopa();
        }

        public IGraph ProdukujGrafike()
        {
            return new GrafikaDlaLaptopa();
        }

        public IRam ProdukujRam()
        {
            return new DDR3();
        }

        public IProcessor ProdukujProcesor()
        {
            return new ProcesorDlaLaptopa();
        }

        public ICooler ProdukujChlodzenie()
        {
            return new ChlodzenieDlaLaptopa();
        }
    }
}
