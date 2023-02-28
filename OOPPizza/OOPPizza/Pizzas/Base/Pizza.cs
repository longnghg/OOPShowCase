using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza.Pizzas.Base
{
    public abstract class Pizza
    {
        protected string name { get; set; }
        protected string dough { get; set; }
        protected string sauce { get; set; }
        protected List<string> toppings { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"\t....Preparing in 4 steps started.......");
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine($"Tossing {dough} dough...");
            Console.WriteLine($"Adding {sauce}...");
            Console.WriteLine($"Adding toppings:");
            toppings?.ForEach((topping) => Console.WriteLine($"\t {topping}"));
        }
        public virtual void Bake()
        {
            Console.WriteLine($"Baking in 20 minutes.......");
        }
        public void Box()
        {
            Console.WriteLine("Boxing.......");
        }
    }
}
