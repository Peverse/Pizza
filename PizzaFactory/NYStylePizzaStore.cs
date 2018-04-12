using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            if (item == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            
            else return null;
        }
    }
}
