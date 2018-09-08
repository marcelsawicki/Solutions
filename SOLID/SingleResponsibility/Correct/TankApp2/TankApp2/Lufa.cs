using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp2
{
    class Lufa
    {
        private int _dlugoscLufy;
        private bool _pociskJestZaladowany;
        private Pocisk _pocisk;

        public Lufa()
        {
            _dlugoscLufy = 120;
            _pociskJestZaladowany = false;
        }

        public void Strzelaj()
        {
            if (_pociskJestZaladowany)
            {
                _pociskJestZaladowany = false;
                // Zniszcz();
            }
            else
            {
                throw new PociskNieJestZaladowany();
            }
        }

        public void LadujPocisk(Pocisk pocisk)
        {
            if (!_pociskJestZaladowany)
            {
                _pociskJestZaladowany = true;
                _pocisk = pocisk;
            }
            else
            {
                throw new PociskJestJuzZaladowany();
            }
        }
    }

    public class PociskJestJuzZaladowany : Exception
    {

    }

    public class PociskNieJestZaladowany : Exception
    {

    }
}
