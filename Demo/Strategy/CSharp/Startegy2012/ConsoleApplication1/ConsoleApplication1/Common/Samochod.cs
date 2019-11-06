using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Samochod : IDrive
	{
        public void Dojezdzaj()
        {
            Console.WriteLine("Dojazd: samochod.");
        }
	}
}
