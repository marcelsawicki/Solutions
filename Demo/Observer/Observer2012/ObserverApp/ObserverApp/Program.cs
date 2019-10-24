using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Observer.");
            Winda winda = new Winda();
            Pasazer pasazer = new Pasazer();
            winda.LosujPietro();
            winda.DodajObserwatora(pasazer);
            winda.PowiadamiajObserwatorow();
            pasazer.Informuj();

            winda.LosujPietro();
            winda.PowiadamiajObserwatorow();
            pasazer.Informuj();
            Console.ReadKey();
        }
    }
}
