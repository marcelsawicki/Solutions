using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Czolg tank2 = new Czolg();
            Pocisk pocisk = new Pocisk();
            tank2.Jedz();
            tank2.LadujPocisk(pocisk);
            tank2.Strzelaj();
            System.Console.ReadKey();
        }
    }
}
