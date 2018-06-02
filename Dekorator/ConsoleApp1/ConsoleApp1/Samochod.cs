using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Samochod
    {
        protected string samochod = "Samochod podstawowy";

        virtual public String About()
        {
            return samochod;
        }

        public abstract double Cena();
    }
}
