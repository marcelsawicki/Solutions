﻿using FabrykaKomputerow.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Model
{
    class DDR3 : IRam
    {
        private string name = "DDR3";

        public IRam dostarczRam()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DDR3();
        }
    }
}
