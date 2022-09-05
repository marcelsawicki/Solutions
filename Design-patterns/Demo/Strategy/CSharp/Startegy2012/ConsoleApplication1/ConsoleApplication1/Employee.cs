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
                drive = new Car();
                spendFreeTime = new Gym();
			}
			else if ((occupation.ToUpper()).Equals("DOCTOR"))
			{
                work = new Heal();
                drive = new Car();
                spendFreeTime = new PopularScienceLiterature();
			}
			else if ((occupation.ToUpper()).Equals("POSTMAN"))
			{
				work = new SpreadLetters();
				drive = new Bicycle();
                spendFreeTime = new Gym();
			}
		}

        public void Methods()
        {
            work.Work();
            drive.Drive();
            spendFreeTime.SpendFreeTime();
        }
    }
}
