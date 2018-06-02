using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class CheeseDecorator: PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza): base(pizza)
        {

        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.15;
        }

        public override string GetName()
        {
            return base.GetName() + " Cheese";
        }
    }
}
