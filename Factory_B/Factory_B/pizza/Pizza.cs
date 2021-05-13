using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.pizza.pizza.type;

namespace Factory_B.pizza
{
    public abstract class Pizza
    {
        protected E_PizzaType pizzaType;
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
        public E_PizzaType getPizzaType()
        {
            return pizzaType;
        }
    }
}
