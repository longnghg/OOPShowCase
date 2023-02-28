using OOPPizza.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Pizzas
{
    public class THCheesePizza : Pizza
    {
        public THCheesePizza()
        {
            name = "Cheese pizza (TH)";
            dough = "thin dough";
            sauce = "tomato sauce";
            toppings.Add("Pine");
            toppings.Add("Cheese");
        }
        public override void Bake()
        {
            Console.WriteLine("this is override (TH) bake: Baking in 12 minutes");
        }

    }
}
