using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private readonly Dictionary<string, double> DefaultToppingType = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };

        private const double MinGramsValue = 1;

        private const double MaxGramsValue = 50;

        private const double BaseCaloriesPerGram = 2;

        private string toppingType;

        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;


        }
        public string ToppingType
        {
            get { return this.toppingType; }

            private set
            {
                if (!this.DefaultToppingType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                else
                {
                    this.toppingType = value.ToLower();
                }
            }
        }
        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < MinGramsValue || value > MaxGramsValue)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [{MinGramsValue}..{MaxGramsValue}].");
                }

                else
                {
                    this.weight = value;
                }
            }
        }

        public double CaloriesPerGram => BaseCaloriesPerGram * this.DefaultToppingType[this.ToppingType];

        public double TotalCalories => CaloriesPerGram * this.Weight;
    }
}
