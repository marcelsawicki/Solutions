using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
	class Pracownik
	{
		private IPracowac pracowac = null;
		private IDojezdzac dojezdzac = null;
		private ISpedzanieWolnegoCzasu spedzanieWolnegoCzasu = null;

		public Pracownik(string zawod)
		{
			if ((zawod.ToUpper()).Equals("MECHANIK"))
			{
                pracowac = new NaprawaSamochodow();
                dojezdzac = new Samochod();
                spedzanieWolnegoCzasu = new Silownia();
			}
			else if ((zawod.ToUpper()).Equals("LEKARZ"))
			{
                pracowac = new Leczenie();
                dojezdzac = new Samochod();
                spedzanieWolnegoCzasu = new LiteraturaPopularnoNaukowa();
			}
			else if ((zawod.ToUpper()).Equals("LISTONOSZ"))
			{
				pracowac = new RoznoszenieListow();
				dojezdzac = new Rower();
                spedzanieWolnegoCzasu = new Silownia();
			}
		}

        public void Methods()
        {
            pracowac.Pracuj();
            dojezdzac.Dojezdzaj();
            spedzanieWolnegoCzasu.SpedzajWolnyCzas();
        }
    }
}
