using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class GrafikaDlaPC : IGraph
    {
        private string name = "Graph for PC";

        public IGraph DeliverGraph()
        {
            Console.WriteLine("Add: " + name);
            return new GrafikaDlaPC();
        }
    }
}
