using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wzorzec projektowy: Obserwator.");
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