using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Czolg tank1 = new Czolg();
            var komunikat = tank1.Jedz();
            System.Console.WriteLine(komunikat);
            System.Console.ReadKey();
        }
    }
}
