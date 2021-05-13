using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.pizza.NY
{
    class NYStylePepperoniPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking 'NY' pepperoni");
        }

        public override void box()
        {
            Console.WriteLine("Boxing 'NY' pepperoni");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting 'NY' pepperoni");
        }

        public override void prepare()
        {
            Console.WriteLine("Prepairing 'NY' pepperoni");
        }
    }
}
