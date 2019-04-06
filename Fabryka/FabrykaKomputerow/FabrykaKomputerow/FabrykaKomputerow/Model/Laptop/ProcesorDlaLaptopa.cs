﻿using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class ProcesorDlaLaptopa : IProcesor
    {
        private string name = "Procesor dla laptopa";

        public IProcesor dostarczProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaLaptopa();
        }
    }
}