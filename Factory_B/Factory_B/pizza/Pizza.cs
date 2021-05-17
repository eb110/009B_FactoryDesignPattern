using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.ingrediens.ingrediens.type;
using Factory_B.pizza.pizza.type;

namespace Factory_B.pizza
{
    public abstract class Pizza
    {
        public string name { get; set; }

        //ingredients
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;

        public override string ToString()
        {
            return "overriden 'ToString()' method";
        }

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
