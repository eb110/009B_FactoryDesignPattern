using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza.pizza.type;

namespace Factory_B.pizza.NY
{
    public class NYStyleCheesePizza : Pizza
    {
        internal NYStyleCheesePizza()
        {
            this.pizzaType = E_PizzaType.CHEESE_PIZZA;
        }
        public override void bake()
        {
            Console.WriteLine("Baking 'NY' cheese");
        }

        public override void box()
        {
            Console.WriteLine("Boxing 'NY' cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting 'NY' cheese");
        }

        public override void prepare()
        {
            Console.WriteLine("Prepairing 'NY' cheese");
        }
    }
}
