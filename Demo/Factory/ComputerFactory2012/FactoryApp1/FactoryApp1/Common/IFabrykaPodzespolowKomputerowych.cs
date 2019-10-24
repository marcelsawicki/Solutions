﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Common
{
    interface IFabrykaPodzespolowKomputerowych
    {
        IDysk ProdukujDysk();
        IGrafika ProdukujGrafike();
        IRam ProdukujRam();
        IProcesor ProdukujProcesor();
        IChlodzenie ProdukujChlodzenie();
    }
}
