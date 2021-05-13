using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza;

namespace Factory_B.store
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza createPizza(String type);
    }
}
