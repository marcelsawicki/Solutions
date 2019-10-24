using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.Laptop
{
    class ChlodzenieDlaLaptopa : IChlodzenie
    {
        private string name = "Chlodzenie dla laptopa";

        public IChlodzenie DostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaLaptopa();
        }
    }
}
