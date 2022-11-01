using System;
using System.Linq;
using System.Collections.Generic;
namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            
            string[] pizzaArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = pizzaArgs[1];

            Pizza pizza = new Pizza(name);

            string[] doughArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string flourType = doughArgs[1];

            string bakingTechnique = doughArgs[2];

            double grams = double.Parse(doughArgs[3]);

            Dough dough = new Dough(flourType, bakingTechnique, grams);

            pizza.Dough = dough;


            while (true)
            {
                string[] toppingArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (toppingArgs[0] == "END")
                {
                    break;
                }

                string toppingType = toppingArgs[1];

                double weight = double.Parse(toppingArgs[2]);

                Topping topping = new Topping(toppingType, weight);

                pizza.AddToppings(topping);
            }

            Console.WriteLine(pizza);
            

        }
    }
}
