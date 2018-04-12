using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            return pizza;
        }
    }
}
