using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class FabrykaPodzespolowPC : IComponentsFactory
    {
        public IDrive ProdukujDysk()
        {
            return new DyskDlaPC();
        }

        public IGraph ProdukujGrafike()
        {
            return new GrafikaDlaPC();
        }

        public IRam ProdukujRam()
        {
            return new DDR2();
        }

        public IProcessor ProdukujProcesor()
        {
            return new ProcesorDlaPC();
        }

        public ICooler ProdukujChlodzenie()
        {
            return new ChlodzenieDlaPC();
        }
    }
}
