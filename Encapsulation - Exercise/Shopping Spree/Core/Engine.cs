using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;

        private List<Person> people;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {

            AddPeople();

            AddProducts();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                string personName = command[0];

                string productName = command[1];

                try
                {
                    Person person = this.people.First(p => p.Name == personName);

                    Product product = this.products.First(p => p.Name == productName);

                    person.BuyProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException iot)
                {

                    Console.WriteLine(iot.Message);
                }
            }

            foreach (var item in this.people)
            {
                Console.WriteLine(item);
            }
        }

        public void AddPeople()
        {
            string[] firstLine = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < firstLine.Length; i++)
            {
                string[] firstLinePartOne = firstLine[i].Split("=").ToArray();

                string name = firstLinePartOne[0];

                decimal money = decimal.Parse(firstLinePartOne[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }
        }

        public void AddProducts()
        {
            string[] secondLine = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < secondLine.Length; i++)
            {
                string[] secondLinePartOne = secondLine[i].Split("=").ToArray();

                string name = secondLinePartOne[0];

                decimal cost = decimal.Parse(secondLinePartOne[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }
    }
}
