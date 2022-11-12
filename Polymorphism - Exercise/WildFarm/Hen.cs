using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double coefficientWithIncreaseWeight = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void AddFood(Food food)
        {
            this.Weight += (coefficientWithIncreaseWeight * food.Quantity);

            this.FoodEaten = food.Quantity;
        }

        public override string ProduceSound()
        {
            return $"Cluck";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
