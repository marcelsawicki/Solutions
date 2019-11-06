using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class Gym : ISpendFreeTime
	{
        public void SpendFreeTime()
        {
            Console.WriteLine("Free time: gym.");
        }
	}
}
