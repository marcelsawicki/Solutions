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
            FabrykaKomputerow fabrykaKomputerow = new FabrykaKomputerow();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("PC");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Komputer pc = fabrykaKomputerow.WydajKomputer("PC");

            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Laptop");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Komputer laptop = fabrykaKomputerow.WydajKomputer("Laptop");

            Console.ReadLine();
        }
    }
}
