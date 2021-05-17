using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.ingrediens;
using Factory_B.pizza;
using Factory_B.pizza.pizza.type;

namespace Factory_B.store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(E_PizzaType type)
        {
            Pizza pizza;
            I_PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case E_PizzaType.CHEESE_PIZZA:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.name = "New York Style Cheese Pizza";
                    break;
                case E_PizzaType.PEPPERONI_PIZZA:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.name = "New York Style Pepperoni Pizza";
                    break;
                case E_PizzaType.CLAM_PIZZA:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.name = "New York Style Clam Pizza";
                    break;
                case E_PizzaType.VEGGIE_PIZZA:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.name = "New York Style Veggie Pizza";
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
