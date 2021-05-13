using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza;
using Factory_B.pizza.pizza.type;

namespace Factory_B.store
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(E_PizzaType type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza createPizza(E_PizzaType type);
    }
}
