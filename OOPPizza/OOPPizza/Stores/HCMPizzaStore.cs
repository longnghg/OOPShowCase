using OOPPizza.Pizzas;
using OOPPizza.Pizzas.Base;
using OOPPizza.Stores.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Stores
{
    public class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HCMCheesePizza();
                case "greek":
                    return new HCMGreekPizza();
                default:
                    return null;
            }
        }
    }
}
