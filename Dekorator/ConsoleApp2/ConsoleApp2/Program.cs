using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();

            largePizza = new CheeseDecorator(largePizza);

            Console.WriteLine(largePizza.GetName());
            Console.WriteLine(largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}