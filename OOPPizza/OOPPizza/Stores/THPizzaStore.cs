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
    public class THPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new THCheesePizza();
                case "greek":
                    return new THGreekPizza();
                default:
                    return null;
            }
        }
    }
}
