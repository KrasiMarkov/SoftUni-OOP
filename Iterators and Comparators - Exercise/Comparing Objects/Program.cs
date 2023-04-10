using System;
using System.Collections.Generic;
using System.Linq;
namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            while (true)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                if (data[0] == "END")
                {
                    break;
                }

                string name = data[0];
                int age = int.Parse(data[1]);
                string town = data[2];

                Person person = new Person(name, age, town);


                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            if (n < people.Count)
            {
                int countOfMathes = 0;

                int numberOfNotEqualPeople = 0;

                int totalNumberOfPeople = 0;

                Person person1 = people[n];

                foreach (var item in people)
                {
                    totalNumberOfPeople++;

                    var result = item.CompareTo(person1);

                    if (result == 0)
                    {
                        countOfMathes++;
                    }

                    else
                    {
                        numberOfNotEqualPeople++;
                    }
                }

                Console.WriteLine($"{countOfMathes} {numberOfNotEqualPeople} {totalNumberOfPeople}");
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
