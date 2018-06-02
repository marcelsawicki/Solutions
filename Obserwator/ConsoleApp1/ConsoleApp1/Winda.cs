using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class Winda: IObserwowany
    {
        private List<IObserwator> obserwatorzy;
        private int pietro;
        Random losowanie = new Random();

        public Winda()
        {
            obserwatorzy = new List<IObserwator>();
            pietro = 0;
        }

        public void DodajObserwatora(IObserwator obserwator)
        {
            obserwatorzy.Add(obserwator);
        }

        public void UsunObserwatora(IObserwator obserwator)
        {
            int index = obserwatorzy.IndexOf(obserwator);
            obserwatorzy.RemoveAt(index);
        }

        public void PowiadamiajObserwatorow()
        {
            foreach (IObserwator obserwator in obserwatorzy)
            {
                obserwator.Update(pietro);
            }
        }

        public void LosujPietro()
        {
            this.pietro = losowanie.Next(0,5);
        }
    }
}
