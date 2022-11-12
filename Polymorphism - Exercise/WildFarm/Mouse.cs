using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double coefficientWithIncreaseWeight = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void AddFood(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                this.Weight += (coefficientWithIncreaseWeight * food.Quantity);

                this.FoodEaten = food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return $"Squeak";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
