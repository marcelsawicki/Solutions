using FabrykaKomputerowProgram.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerowProgram.Model
{
    class ProcesorDlaPC : IProcesor
    {
        private string name = "Procesor dla PC";

        public IProcesor DostarczProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaPC();
        }
    }
}
