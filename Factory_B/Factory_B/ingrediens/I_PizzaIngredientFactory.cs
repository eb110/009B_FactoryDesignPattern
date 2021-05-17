using Factory_B.ingrediens.ingrediens.type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.ingrediens
{
    public interface I_PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        Veggies[] createVeggies();
        Pepperoni createPepperoni();
        Clams createClam();
    }


}
