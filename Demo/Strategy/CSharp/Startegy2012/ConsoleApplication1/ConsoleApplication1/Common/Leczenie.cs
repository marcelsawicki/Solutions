using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Leczenie : IWork
	{
        public void Pracuj()
        {
            Console.WriteLine("Praca: leczy ludzi.");
        }
	}
}
