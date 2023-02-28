using OOPPizza.Stores;
using OOPPizza.Stores.Base;

PizzaStore hcmPizzaStore = new HCMPizzaStore();
hcmPizzaStore.OrderPizza("cheese");
PizzaStore thPizzaStore = new THPizzaStore();
thPizzaStore.OrderPizza("cheese");








//namespace OOPPizza 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var pizza = new Pizza();
//        }
//    }
//}