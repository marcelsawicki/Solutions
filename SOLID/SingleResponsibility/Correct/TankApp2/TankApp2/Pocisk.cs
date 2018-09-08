using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp2
{
    class Pocisk
    {
        private double _trafnoscPocisku;
        private bool _pociskaZostalZuzyty;
        private bool _pociskZniszczylCel;

        public Pocisk()
        {
            _trafnoscPocisku = 0.5;
            _pociskZniszczylCel = false;
            _pociskaZostalZuzyty = false;
        }

        public void Zniszcz()
        {
            if (!SprawdzCzyPociskZostalZuzyty())
            {
                _pociskaZostalZuzyty = true;

                if (SprawdzCzyPociskZniszczylCel())
                    _pociskZniszczylCel = true;
                else
                    _pociskZniszczylCel = false;
            }
            else
            {
                throw new PociskZostalJuzZuzyty();
            }
        }

        private bool SprawdzCzyPociskZostalZuzyty()
        {
            return _pociskaZostalZuzyty == false;
        }

        private bool SprawdzCzyPociskZniszczylCel()
        {
            var rand = new Random();
            return rand.NextDouble() < _trafnoscPocisku;
        }
    }

    public class PociskNieZostalZuzyty : Exception
    {

    }

    public class PociskZostalJuzZuzyty : Exception
    {

    }
}
