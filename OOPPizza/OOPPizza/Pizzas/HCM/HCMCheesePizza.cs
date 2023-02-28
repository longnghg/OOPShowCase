using OOPPizza.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Pizzas
{
    public class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "Cheese pizza (HCM)";
            dough = "thin dough";
            sauce = "tomato sauce";
            toppings.Add("Pine");
            toppings.Add("Cheese");
        }
        public override void Bake()
        {
            Console.WriteLine("this is override (HCM) bake: Baking in 10 minutes");
        }

    }
}
