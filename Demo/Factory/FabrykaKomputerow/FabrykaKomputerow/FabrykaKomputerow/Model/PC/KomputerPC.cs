using FabrykaKomputerowProgram.Common;
using FabrykaKomputerowProgram.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerowProgram.Model.PC
{
    class KomputerPC : Komputer
    {
        private readonly IFabrykaPodzespolowKomputerowych _fabrykaPodzespolowKomputerowych;

        public KomputerPC(IFabrykaPodzespolowKomputerowych fabrykaPodzespolowKomputerowych)
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
