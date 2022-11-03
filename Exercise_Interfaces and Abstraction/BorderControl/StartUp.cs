using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> myCollection = new List<IBuyer>();

            int food = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split().ToArray();

                if (people.Length == 4)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string id = people[2];
                    string birthdate = people[3];

                    IBuyer citizen = new Citizen(age, id, birthdate);
                    citizen.Name = name;
                    myCollection.Add(citizen);
                }

                else if (people.Length == 3)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string group = people[2];


                    IBuyer rebel = new Rebel(age, group);
                    rebel.Name = name;
                    myCollection.Add(rebel);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var item in myCollection)
                {
                    if (item.Name == command)
                    {
                        item.BuyFood();
                        food += item.Food;
                        item.Food = 0;
                    }
                }

            }

            Console.WriteLine(food);


        }
    }
}
