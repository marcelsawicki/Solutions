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
        private string name = "Cooler for PC";

        public ICooler DeliverCooler()
        {
            Console.WriteLine("Add: " + name);
            return new ChlodzenieDlaPC();
        }
    }
}
