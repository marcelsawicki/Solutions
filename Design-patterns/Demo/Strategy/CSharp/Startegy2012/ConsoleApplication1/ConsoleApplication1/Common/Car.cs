﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Car : IDrive
	{
        public void Drive()
        {
            Console.WriteLine("Drive: car.");
        }
	}
}
