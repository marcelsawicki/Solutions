using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Common.Abstract
{
    abstract class Komputer
    {
        protected IDysk dysk;
        protected IGrafika grafika;
        protected IRam ram;
        protected IProcesor procesor;
        protected IChlodzenie chlodzenie;

        public abstract void Skladanie();

        public void InstalowanieOprogramowania()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Instaluje oprogramowanie...");
        }

        public void Pakowanie()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pakuje sprzet...");
        }

        public void Sprzedawanie()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sprzedaje sprzet...");
        }
    }
}
