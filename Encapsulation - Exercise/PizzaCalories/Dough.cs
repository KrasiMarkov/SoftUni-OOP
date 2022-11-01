using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private readonly Dictionary<string, double> DefaultFlourType = new Dictionary<string, double>()
        {
            {"white", 1.5},
            {"wholegrain", 1.0}

        };

        private readonly Dictionary<string, double> DefaultBakingTechnique = new Dictionary<string, double>()
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };

        private const double BaseCaloriesPerGram = 2;

        private const double MinGramsValue = 1;

        private const double MaxGramsValue = 200;

        private string flourType;

        private string bakingTechnique;

        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;


        }

        public string FlourType
        {
            get { return this.flourType; }

            private set
            {
                if (!this.DefaultFlourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                else
                {
                    this.flourType = value.ToLower();
                }
            }




        }


        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            private set
            {
                if (!this.DefaultBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                else
                {
                    this.bakingTechnique = value.ToLower();
                }
            }
        }


        public double Grams
        {
            get { return this.grams; }
            private set
            {
                if (value < MinGramsValue || value > MaxGramsValue)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinGramsValue}..{MaxGramsValue}].");
                }

                else
                {
                    this.grams = value;
                }
            }
        }

        public double CaloriesPerGram => BaseCaloriesPerGram * this.DefaultFlourType[this.FlourType] * this.DefaultBakingTechnique[this.BakingTechnique];

        public double TotalCalories => CaloriesPerGram * this.Grams;
    }
}
