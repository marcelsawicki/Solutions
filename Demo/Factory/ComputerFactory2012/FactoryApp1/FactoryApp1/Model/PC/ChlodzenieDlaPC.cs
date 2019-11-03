using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class ChlodzenieDlaPC : ICooler
    {
        private string name = "Chlodzenie dla PC";

        public ICooler DostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaPC();
        }
    }
}
