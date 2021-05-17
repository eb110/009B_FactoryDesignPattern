using Factory_B.ingrediens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.pizza
{
    class VeggiePizza : Pizza
    {
        I_PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(I_PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void bake()
        {
            Console.WriteLine("bake for 20 min as it is veggie pizza");
        }

        public override void box()
        {
            Console.WriteLine("box it as for veggie pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cut is as for veggie pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Prepairing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            veggies = ingredientFactory.createVeggies();
        }
    }
}