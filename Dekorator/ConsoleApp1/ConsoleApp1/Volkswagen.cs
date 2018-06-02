using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Volkswagen: Samochod
    {
        public Volkswagen()
        {
            samochod = "Volkswagen";
        }

        public override double Cena()
        {
            return 100000;
        }
    }
}
