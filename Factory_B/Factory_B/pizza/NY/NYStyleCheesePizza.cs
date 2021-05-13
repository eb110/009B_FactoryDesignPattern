using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.pizza.NY
{
    class NYStyleCheesePizza : Pizza
    {
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
