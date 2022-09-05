using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class LargePizza: Pizza
    {
        public override double CalculateCost()
        {
            return 50.00;
        }

        public override string GetName()
        {
            return "Large Pizza";
        }
    }
}
