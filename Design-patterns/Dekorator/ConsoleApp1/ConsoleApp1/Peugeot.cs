using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Peugeot: Samochod
    {
        public Peugeot()
        {
            samochod = "Peugeot";
        }

        public override double Cena()
        {
            return 100000;
        }
    }
}
