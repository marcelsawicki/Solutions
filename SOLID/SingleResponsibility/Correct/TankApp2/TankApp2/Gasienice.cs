using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp2
{
    class Gasienice
    {
        private int _predkoscMaksynalna;

        public Gasienice()
        {
            _predkoscMaksynalna = 60;
        }

        public void Jedz()
        {
            Console.WriteLine("Przechajales krotka odleglosc. Ale wjechales pod gorke.");
        }
    }
}
