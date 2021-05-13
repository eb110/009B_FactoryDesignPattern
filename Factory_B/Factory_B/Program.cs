using System;
using Factory_B.store;
using Factory_B.pizza;

namespace Factory_B
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza pepperoniPizza = nyPizzaStore.orderPizza("cheese");
            Console.WriteLine("Hello World!");
        }
    }
}
