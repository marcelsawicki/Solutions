using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class GrafikaDlaLaptopa : IGraph
    {
        private string name = "Grafika dla laptopa";

        public IGraph DostarczGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaLaptopa();
        }
    }
}
