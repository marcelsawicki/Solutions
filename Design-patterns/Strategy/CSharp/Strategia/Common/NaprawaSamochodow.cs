﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
	class NaprawaSamochodow : IPracowac
	{
        public void Pracuj()
        {
            Console.WriteLine("Praca: naprawia samochody.");
        }
	}
}
