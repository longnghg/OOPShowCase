using OOPPizza.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Pizzas
{
    public class THGreekPizza : Pizza
    {
        public THGreekPizza()
        {
            name = "Greek pizza (TH)";
            dough = "thick dough";
            sauce = "spice sauce";
            toppings.Add("Sausage");
            toppings.Add("Potato");
        }
    }
}
