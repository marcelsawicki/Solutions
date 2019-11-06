using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Employee
	{
		private IWork work = null;
		private IDrive drive = null;
		private ISpendFreeTime spendFreeTime = null;

		public Employee(string occupation)
		{
			if ((occupation.ToUpper()).Equals("MECHANIC"))
			{
                work = new FixCars();
                drive = new Samochod();
                spendFreeTime = new Silownia();
			}
			else if ((occupation.ToUpper()).Equals("DOCTOR"))
			{
                work = new Leczenie();
                drive = new Samochod();
                spendFreeTime = new LiteraturaPopularnoNaukowa();
			}
			else if ((occupation.ToUpper()).Equals("POSTMAN"))
			{
				work = new RoznoszenieListow();
				drive = new Rower();
                spendFreeTime = new Silownia();
			}
		}

        public void Methods()
        {
            work.Work();
            drive.Dojezdzaj();
            spendFreeTime.SpedzajWolnyCzas();
        }
    }
}
