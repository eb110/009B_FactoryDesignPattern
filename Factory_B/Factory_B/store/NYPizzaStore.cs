using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza;
using Factory_B.pizza.NY;

namespace Factory_B.store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }

        }
    }
}
