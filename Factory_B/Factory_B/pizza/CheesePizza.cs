using Factory_B.ingrediens;
using Factory_B.pizza.pizza.type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.pizza
{
    public class CheesePizza : Pizza
    {
        protected CheesePizza()
        {
            this.pizzaType = E_PizzaType.CHEESE_PIZZA;
        }

        I_PizzaIngredientFactory ingredientFactory;

        public CheesePizza(I_PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void bake()
        {
            Console.WriteLine("bake for 20 min as it is cheese pizza");
        }

        public override void box()
        {
            Console.WriteLine("box it as for cheese pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cut is as for cheese pizza");
        }

        public override void prepare()
        {
            Console.WriteLine("Prepairing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
