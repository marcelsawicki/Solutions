﻿using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model
{
    class DDR2 : IRam
    {
        private string name = "DDR2";

        public IRam DeliverRam()
        {
            Console.WriteLine("Add: " + name);
            return new DDR2();
        }
    }
}
