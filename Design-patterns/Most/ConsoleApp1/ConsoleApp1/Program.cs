using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Plyta ob1 = new KPlyta(Tlok.dvd, "TDK", new Nagrywanie());
			Plyta ob2 = new KPlyta(Tlok.cd, "Dysan", new Odczytywanie());
			ob1.Akcja();
			Console.WriteLine(ob1.Get() + "\n");
			ob2.Akcja();
			Console.WriteLine(ob2.Get() + "\n");
			ob1.Set("Verbatim", Tlok.bd);
			ob1.Akcja();
			Console.WriteLine(ob1.Get() + "\n");
			Console.ReadKey(true);
		}
    }
}
