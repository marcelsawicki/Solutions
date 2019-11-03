using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class ProcesorDlaLaptopa : IProcessor
    {
        private string name = "Processor for laptop";

        public IProcessor DeliverProcessor()
        {
            Console.WriteLine("Add: " + name);
            return new ProcesorDlaLaptopa();
        }
    }
}
