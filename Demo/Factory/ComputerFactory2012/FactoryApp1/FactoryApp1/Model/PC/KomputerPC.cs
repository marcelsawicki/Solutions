using FactoryApp1.Common;
using FactoryApp1.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class KomputerPC : Computer
    {
        private readonly IComponentsFactory _fabrykaPodzespolowKomputerowych;

        public KomputerPC(IComponentsFactory fabrykaPodzespolowKomputerowych)
        {
            _fabrykaPodzespolowKomputerowych = fabrykaPodzespolowKomputerowych;
            Skladanie();
        }

        public override void Skladanie()
        {
            dysk = _fabrykaPodzespolowKomputerowych.ProdukujDysk().DostarczDysk();
            grafika = _fabrykaPodzespolowKomputerowych.ProdukujGrafike().DostarczGrafike();
            procesor = _fabrykaPodzespolowKomputerowych.ProdukujProcesor().DostarczProcesor();
            ram = _fabrykaPodzespolowKomputerowych.ProdukujRam().DostarczRam();
            chlodzenie = _fabrykaPodzespolowKomputerowych.ProdukujChlodzenie().DostarczChlodzenie();
        }
    }
}
