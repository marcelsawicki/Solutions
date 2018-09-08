using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp2
{
    class Czolg
    {
        private Pancerz _pancerz;
        private Lufa _lufa;
        private Gasienice _gasienice;

        public Czolg()
        {
            _pancerz = new Pancerz();
            _lufa = new Lufa();
            _gasienice = new Gasienice();
        }

        public void Jedz()
        {
            _gasienice.Jedz();
        }

        public void Strzelaj()
        {
            _lufa.Strzelaj();
        }

        public void LadujPocisk(Pocisk pocisk)
        {
            _lufa.LadujPocisk(pocisk);
        }
    }
}
