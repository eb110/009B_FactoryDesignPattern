using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.ingrediens.ingrediens.type;
using Factory_B.ingrediens.ingrediens.type.ingrediens.subtype;
using Factory_B.ingrediens.vegetables;

namespace Factory_B.ingrediens
{
    public class NYPizzaIngredientFactory : I_PizzaIngredientFactory
    {
        public NYPizzaIngredientFactory()
        {
            Console.WriteLine("This is NY Style ingrediens factory");
        }
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinarasSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

    }
}
