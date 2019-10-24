using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class GrafikaDlaPC : IGrafika
    {
        private string name = "Grafika dla PC";

        public IGrafika DostarczGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaPC();
        }
    }
}
