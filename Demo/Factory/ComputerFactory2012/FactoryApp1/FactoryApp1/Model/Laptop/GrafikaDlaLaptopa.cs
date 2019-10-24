using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class GrafikaDlaLaptopa : IGrafika
    {
        private string name = "Grafika dla laptopa";

        public IGrafika DostarczGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaLaptopa();
        }
    }
}
