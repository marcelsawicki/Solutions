using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp1
{
    class Czolg
    {
        private readonly double _trafnoscPocisku;
        private readonly int _gruboscPancerza;
        private readonly int _dlugoscLufy;
        private readonly int _predkoscMaksynalna;
        private bool _pociskJestZaladowany;
        private bool _pociskaZostalZuzyty;
        private bool _pociskZniszczylCel;

        public Czolg()
        {
            _predkoscMaksynalna = 60;
            _dlugoscLufy = 120;
            _gruboscPancerza = 30;
            _trafnoscPocisku = 0.5;
            _pociskJestZaladowany = false;
            _pociskZniszczylCel = false;
            _pociskaZostalZuzyty = false;
        }

        public string Jedz()
        {
            return "Przechajales krotka odleglosc,  ale wjechales pod gorke.";
        }

        public void Strzelaj()
        {
            if (_pociskJestZaladowany)
            {
                _pociskJestZaladowany = false;
                Zniszcz();
            }
            else
            {
                throw new PociskNieJestZaladowany();
            }
        }

        public void LadujPocisk()
        {
            if (!_pociskJestZaladowany)
            {
                _pociskJestZaladowany = true;
            }
            else
            {
                throw new PociskJestJuzZaladowany();
            }
        }

        private void Zniszcz()
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

    public class PociskJestJuzZaladowany : Exception
    {

    }

    public class PociskNieJestZaladowany : Exception
    {

    }
}
