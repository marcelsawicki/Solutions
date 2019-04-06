using FabrykaKomputerowProgram.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerowProgram.Model.PC
{
    class ChlodzenieDlaPC : IChlodzenie
    {
        private string name = "Chlodzenie dla PC";

        public IChlodzenie DostarczChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDlaPC();
        }
    }
}
