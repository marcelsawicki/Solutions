using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Leczenie : IWork
	{
        public void Work()
        {
            Console.WriteLine("Work: heal the people.");
        }
	}
}
