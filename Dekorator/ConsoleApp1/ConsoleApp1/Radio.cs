using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Radio: Dekorator
    {
        Samochod car;
            public Radio(Samochod samochod)
            {
                car = samochod;
            }

            public override String About()
            {
                return car.About() + " + radio";
            }

            public override double Cena()
            {
                return car.Cena() + 300;
            }
    }
}
