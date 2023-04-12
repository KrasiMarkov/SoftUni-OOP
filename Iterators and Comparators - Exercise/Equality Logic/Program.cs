using System;
using System.Linq;
using System.Collections.Generic;
namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();

            HashSet<Person> peopleHashSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string name = data[0];
                int age = int.Parse(data[1]);


                Person person = new Person(name, age);

                peopleSortedSet.Add(person);

                peopleHashSet.Add(person);
            }

            Console.WriteLine($"{peopleSortedSet.Count}");
            Console.WriteLine($"{peopleHashSet.Count}");
        }
    }
}
