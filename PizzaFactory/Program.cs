using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ruud ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("pepperoni");
            Console.WriteLine("Jordy ordered a " + pizza.getName() + "\n");

            Console.Read();

        }
    }
}
