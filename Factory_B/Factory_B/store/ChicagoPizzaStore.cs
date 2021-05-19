using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.ingrediens;
using Factory_B.pizza;
using Factory_B.pizza.pizza.type;

namespace Factory_B.store
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(E_PizzaType type)
        {
            Pizza pizza;
            I_PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientsFactory();

            switch (type)
            {
                case E_PizzaType.CHEESE_PIZZA:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.pizzaType = type;
                    pizza.name = "Chicago Style Cheese Pizza";
                    break;
                case E_PizzaType.PEPPERONI_PIZZA:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.pizzaType = type;
                    pizza.name = "Chicago Style Pepperoni Pizza";
                    break;
                case E_PizzaType.CLAM_PIZZA:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.pizzaType = type;
                    pizza.name = "Chicago Style Clam Pizza";
                    break;
                case E_PizzaType.VEGGIE_PIZZA:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.pizzaType = type;
                    pizza.name = "Chicago Style Veggie Pizza";
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }

    }
}
