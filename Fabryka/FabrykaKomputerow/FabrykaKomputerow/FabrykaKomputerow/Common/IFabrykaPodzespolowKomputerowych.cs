using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Common
{
    interface IFabrykaPodzespolowKomputerowych
    {
        IDysk produkujDysk();
        IGrafika produkujGrafike();
        IRam produkujRam();
        IProcesor produkujProcesor();
        IChlodzenie produkujChlodzenie();
    }
}
