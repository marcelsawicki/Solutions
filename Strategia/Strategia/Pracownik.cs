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
			}
			else if ((zawod.ToUpper()).Equals("LEKARZ"))
			{
			}
			else if ((zawod.ToUpper()).Equals("LISTONOSZ"))
			{
				pracowac = new RoznoszenieListow();
				dojezdzac = new Rower();
		
			}
		}

	}
}
