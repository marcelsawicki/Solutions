﻿using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class ProcesorDlaLaptopa : IProcesor
    {
        private string name = "Procesor dla laptopa";

        public IProcesor DostarczProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaLaptopa();
        }
    }
}
