using OOPPizza.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Pizzas
{
    public class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "Greek pizza (HCM)";
            dough = "thick dough";
            sauce = "spice sauce";
            toppings.Add("Sausage");
            toppings.Add("Potato");
        }
    }
}
