using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            do
            {
                Console.Write("Occupation (doctor, mechanic, postman): ");
                string occupation = Console.ReadLine();
                try
                {
                    Employee employee = new Employee(occupation);
                    employee.Methods();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong profession.");
                }
                Console.WriteLine("End - finishes program, <ENTER> - choose profession");
                command = Console.ReadLine();
            }
            while (!(command.ToUpper()).Equals("END"));
        }
    }
}
