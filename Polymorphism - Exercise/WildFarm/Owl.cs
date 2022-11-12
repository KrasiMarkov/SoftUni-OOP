using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double coefficientWithIncreaseWeight = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void AddFood(Food food)
        {
            if (food.GetType().Name == "Meat")
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
            return $"Hoot Hoot";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
