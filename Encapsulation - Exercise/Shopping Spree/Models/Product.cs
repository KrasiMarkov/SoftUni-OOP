using ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;

        private decimal cost;

        private const decimal COST_MIN_VALUE = 0m;

        public Product(string name, decimal cost)
        {

            this.Cost = cost;
            this.Name = name;

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                else
                {
                    this.name = value;
                }
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < COST_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }

                else
                {
                    this.cost = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
