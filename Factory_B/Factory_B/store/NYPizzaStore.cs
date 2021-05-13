using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza;
using Factory_B.pizza.NY;
using Factory_B.pizza.pizza.type;

namespace Factory_B.store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(E_PizzaType type)
        {
            Pizza pizza;
            switch (type)
            {
                case E_PizzaType.CHEESE_PIZZA:
                    NYStyleCheesePizza cheesePizza = new NYStyleCheesePizza();
                    pizza = cheesePizza;
                    break;
                case E_PizzaType.PEPPERONI_PIZZA:
                    NYStylePepperoniPizza pepperoniPizza = new NYStylePepperoniPizza();
                    pizza = pepperoniPizza;
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
