using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PizzaFactory
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public ArrayList toppings = new ArrayList();

        public void prepare()
        {
            Console.WriteLine("preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for(int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("   " + toppings[i]);
            }
        }

        public void bake()
        {
            Console.WriteLine("Baking a pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing the pizza");
        }

        public string getName()
        {
            return name;
        }
    }
}
