using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class ProcesorDlaPC : IProcessor
    {
        private string name = "Processor for PC";

        public IProcessor DeliverProcessor()
        {
            Console.WriteLine("Add: " + name);
            return new ProcesorDlaPC();
        }
    }
}
