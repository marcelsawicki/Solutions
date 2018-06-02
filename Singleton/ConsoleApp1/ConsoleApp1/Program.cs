using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");

            World obiekt1 = World.Utworz();
            obiekt1.GetInstance();
            World.Utworz();
            obiekt1.GetInstance();
            World.Utworz();
            Console.WriteLine("Teraz juz nie moge utworzyc instancji klasy World.");
            World abc = World.Utworz();

            Console.ReadKey();
        }
    }
}