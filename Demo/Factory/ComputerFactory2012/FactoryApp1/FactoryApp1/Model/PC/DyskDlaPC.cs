using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class DyskDlaPC : IDysk
    {
        private string name = "Dysk dla PC";

        public IDysk DostarczDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaPC();
        }
    }
}
