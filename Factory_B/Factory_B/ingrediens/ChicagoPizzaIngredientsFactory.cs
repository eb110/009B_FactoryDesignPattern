using System;
using System.Collections.Generic;
using System.Text;
using Factory_B.ingrediens.ingrediens.type;
using Factory_B.ingrediens.ingrediens.type.ingrediens.subtype;
using Factory_B.ingrediens.vegetables;

namespace Factory_B.ingrediens
{
    class ChicagoPizzaIngredientsFactory : I_PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams createClam()
        {
            return new FrozenClams();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}
