using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista samochodow bez wyposarzenia: ");
            Console.WriteLine("\n");
            Samochod vw = new Volkswagen();
            Samochod peugeot = new Peugeot();
            
            Console.WriteLine(vw.About());
            Console.WriteLine("Cena: "+ vw.Cena() +" zl");
            Console.WriteLine("\n");
            Console.WriteLine(peugeot.About());
            Console.WriteLine("Cena: "+ peugeot.Cena() +" zl");

            // Dekoruje
            Console.WriteLine("Dekoruje: ");
            vw = new Radio(vw);
            vw = new Klimatyzacja(vw);
            Console.WriteLine(vw.About());
            Console.WriteLine("Cena: " + vw.Cena() + " zl");
            Console.WriteLine("\n");

            Console.WriteLine("Dekoruje: ");
            peugeot = new Klimatyzacja(peugeot);
            Console.WriteLine(peugeot.About());
            Console.WriteLine("Cena: " + peugeot.Cena() + " zl");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}