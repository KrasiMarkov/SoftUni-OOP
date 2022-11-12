using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double coefficientWithIncreaseWeight = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void AddFood(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
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
            return $"Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
