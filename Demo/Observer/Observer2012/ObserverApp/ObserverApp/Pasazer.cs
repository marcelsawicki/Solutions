using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverApp
{
    class Pasazer: IObserwator
    {
        private int pietro;
        public void Update(int pietro)
        {
            this.pietro = pietro;
        }

        public void Informuj()
        {
            Console.WriteLine("Pasazer zaobserwowal ze winda jest na pietrze: " + pietro);
        }
    }
}
