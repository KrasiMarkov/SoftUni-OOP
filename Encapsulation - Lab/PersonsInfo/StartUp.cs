using System;
using System.Linq;
using System.Collections.Generic;
namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {

                string[] info = Console.ReadLine().Split().ToArray();

                string firstName = info[0];

                string secondName = info[1];

                int age = int.Parse(info[2]);

                decimal salary = decimal.Parse(info[3]);

                Person person = new Person(firstName, secondName, age, salary);

                people.Add(person);
            }

            //decimal percentage = decimal.Parse(Console.ReadLine());

            Team team = new Team("TopTeam");

            foreach (Person player in people)
            {

                //item.IncreaseSalary(percentage);
                //Console.WriteLine(item.ToString().TrimEnd());

                team.AddPlayer(player);


            }


            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");



        }
    }
}
