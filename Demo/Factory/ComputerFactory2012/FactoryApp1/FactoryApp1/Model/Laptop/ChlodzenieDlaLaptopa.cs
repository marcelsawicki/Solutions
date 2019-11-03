using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.Laptop
{
    class ChlodzenieDlaLaptopa : ICooler
    {
        private string name = "Chlodzenie dla laptopa";

        public ICooler DostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaLaptopa();
        }
    }
}
