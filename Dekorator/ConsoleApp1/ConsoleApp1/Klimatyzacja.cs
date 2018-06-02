using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Klimatyzacja: Dekorator
    {
        Samochod car;
        public Klimatyzacja(Samochod samochod)
        {
            car = samochod;
        }

        public override String About()
        {
            return car.About() + " + klimatyzacja";
        }

        public override double Cena()
        {
            return car.Cena() + 500;
        }
    }
}
