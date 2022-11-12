using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private const double coefficientWithIncreaseWeight = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
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
            return $"Woof!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
