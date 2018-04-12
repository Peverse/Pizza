using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            if (item == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }

            else if (item == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
