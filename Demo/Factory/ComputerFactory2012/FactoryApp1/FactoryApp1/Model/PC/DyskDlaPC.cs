using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class DyskDlaPC : IDrive
    {
        private string name = "Dysk dla PC";

        public IDrive DostarczDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaPC();
        }
    }
}
