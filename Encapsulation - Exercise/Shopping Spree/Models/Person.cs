using ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {

        private string name;

        private decimal money;

        private List<Product> bag;

        private const decimal MONEY_MIN_VALUE = 0m;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
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

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < MONEY_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }

                else
                {
                    this.money = value;
                }
            }
        }

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly();

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException(string.Format(GlobalConstants.InsufficientMoneyExceptionMessage, this.Name, product.Name));
            }

            else
            {
                this.Money -= product.Cost;
                this.bag.Add(product);
            }
        }

        public override string ToString()
        {
            string productsOutput = "";

            if (this.Bag.Count > 0)
            {
                productsOutput = string.Join(", ", this.Bag);
            }
            else
            {
                productsOutput = "Nothing bought";
            }



            return $"{this.Name} - {productsOutput}";
        }

    }
}
