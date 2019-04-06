using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model.PC
{
    class FabrykaPodzespolowPC : IFabrykaPodzespolowKomputerowych
    {
        public IDysk produkujDysk()
        {
            return new DyskDlaPC();
        }

        public IGrafika produkujGrafike()
        {
            return new GrafikaDlaPC();
        }

        public IRam produkujRam()
        {
            return new DDR2();
        }

        public IProcesor produkujProcesor()
        {
            return new ProcesorDlaPC();
        }

        public IChlodzenie produkujChlodzenie()
        {
            return new ChlodzenieDlaPC();
        }
    }
}
