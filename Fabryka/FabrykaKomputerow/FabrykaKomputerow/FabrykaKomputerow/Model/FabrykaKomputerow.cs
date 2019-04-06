using FabrykaKomputerow.Common.Abstract;
using FabrykaKomputerow.Model.PC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class FabrykaKomputerow
    {
        public Komputer WydajKomputer(string model)
        {
            Komputer komputer = ZlozKomputer(model);
            komputer.InstalowanieOprogramowania();
            komputer.Pakowanie();
            komputer.Sprzedawanie();
            return komputer;
        }

        protected Komputer ZlozKomputer(string model)
        {
            Komputer komputer = null;

            if(model.Equals("PC"))
            {
                komputer = new KomputerPC(new FabrykaPodzespolowPC());
            }
            else
            {
            }

            return komputer;
        }
    }
}
