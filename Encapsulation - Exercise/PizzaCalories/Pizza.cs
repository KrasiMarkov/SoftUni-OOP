using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MaxSymbols = 15;

        private const int MinSymbols = 1;

        private const int MaxToppings = 10;

        private string name;

        private Dough dough;

        private readonly List<Topping> topings;

        public Pizza(string name)
        {
            this.Name = name;

            this.topings = new List<Topping>();
        }


        public string Name
        {

            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < MinSymbols || value.Length > MaxSymbols)
                {
                    throw new ArgumentException($"Pizza name should be between {MinSymbols} and {MaxSymbols} symbols.");
                }

                else
                {
                    this.name = value;
                }
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }

        public void AddToppings(Topping topping)
        {
            if (topings.Count == MaxToppings)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppings}].");
            }

            else
            {
                topings.Add(topping);
            }
        }

        public int CountToppings => this.topings.Count;

        private double CalculateTotalCalories()
        {
            double result = dough.TotalCalories;

            foreach (var item in topings)
            {
                result += item.TotalCalories;
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateTotalCalories():F2} Calories.";
        }
    }
}
