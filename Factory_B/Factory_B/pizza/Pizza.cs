using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_B.pizza
{
    public abstract class Pizza
    {
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
    }
}
