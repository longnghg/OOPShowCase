using OOPPizza.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Stores.Base
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            if (pizza == null)
            {
                Console.WriteLine($"we do not have {type} pizza");
                return;
            }
           
            pizza.Prepare();
            pizza.Bake();
            pizza.Box();
        }
        protected abstract  Pizza CreatePizza(string type);
    }
}
