using FactoryApp1.Common.Abstract;
using FactoryApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputersFactory computersFactory = new ComputersFactory();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("PC");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Computer pc = computersFactory.GetComputer("PC");

            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Laptop");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Computer laptop = computersFactory.GetComputer("Laptop");

            Console.ReadLine();
        }
    }
}
