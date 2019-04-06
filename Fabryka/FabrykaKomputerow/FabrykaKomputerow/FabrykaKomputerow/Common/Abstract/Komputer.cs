using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaKomputerow.Common.Abstract
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
            Console.WriteLine("Instaluje oprowgramowanie...");
        }

        public void Pakowanie()
        {
            Console.WriteLine("Pakuje sprzet...");
        }

        public void Sprzedawanie()
        {
            Console.WriteLine("Sprzedaje sprzet...");
        }
    }
}
