using FabrykaKomputerowProgram.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerowProgram.Model.PC
{
    class FabrykaPodzespolowPC : IFabrykaPodzespolowKomputerowych
    {
        public IDysk ProdukujDysk()
        {
            return new DyskDlaPC();
        }

        public IGrafika ProdukujGrafike()
        {
            return new GrafikaDlaPC();
        }

        public IRam ProdukujRam()
        {
            return new DDR2();
        }

        public IProcesor ProdukujProcesor()
        {
            return new ProcesorDlaPC();
        }

        public IChlodzenie ProdukujChlodzenie()
        {
            return new ChlodzenieDlaPC();
        }
    }
}
