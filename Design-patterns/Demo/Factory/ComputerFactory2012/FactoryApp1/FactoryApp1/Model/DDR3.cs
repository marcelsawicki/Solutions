﻿using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class DDR3 : IRam
    {
        private string name = "DDR3";

        public IRam DeliverRam()
        {
            Console.WriteLine("Add: " + name);
            return new DDR3();
        }
    }
}
