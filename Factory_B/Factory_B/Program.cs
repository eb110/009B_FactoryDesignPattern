using System;
using Factory_B.store;
using Factory_B.pizza;
using Factory_B.pizza.pizza.type;

namespace Factory_B
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza pepperoniPizzaNY = nyPizzaStore.orderPizza(E_PizzaType.PEPPERONI_PIZZA);
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            Pizza pepperoniPizzaChicago = chicagoPizzaStore.orderPizza(E_PizzaType.PEPPERONI_PIZZA);
            Console.WriteLine("Hello World!");
        }
    }
}
