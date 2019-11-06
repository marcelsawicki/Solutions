using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Observer.");
            Lift lift = new Lift();
            Passenger passenger = new Passenger();
            lift.RandomFloor();
            lift.AddObserver(passenger);
            lift.InformObservers();
            passenger.Inform();

            lift.RandomFloor();
            lift.InformObservers();
            passenger.Inform();
            Console.ReadKey();
        }
    }
}
