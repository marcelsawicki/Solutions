using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
	class Program
	{
		static void Main(string[] args)
		{
            string komendy;
            do
            {
                Console.Write("Zawod (lekarz, mechanik, listonosz): ");
                String zawod = Console.ReadLine();
                try
                {
                    Pracownik pracownik = new Pracownik(zawod);
                    pracownik.Methods();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nie ma takiego zawodu.");
                }
                Console.WriteLine("Koniec - koniec programu, <ENTER> - ponowna mozliwosc wyboru zawodu");
                komendy = Console.ReadLine();
            }
            while (!(komendy.ToUpper()).Equals("KONIEC"));

		}
	}
}
