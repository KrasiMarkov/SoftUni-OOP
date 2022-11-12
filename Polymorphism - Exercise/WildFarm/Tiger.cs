using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double coefficientWithIncreaseWeight = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
           : base(name, weight, livingRegion, breed)
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
            return $"ROAR!!!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
