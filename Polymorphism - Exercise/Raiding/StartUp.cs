using System;
using System.Linq;
using System.Collections.Generic;
namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> myList = new List<BaseHero>();

            int counter = 0;

            int n = int.Parse(Console.ReadLine());

            while(n != counter)
            {
                
                string name = Console.ReadLine();

                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    Druid druid = new Druid(name);
                    myList.Add(druid);
                    counter++;
                }

                else if (type == "Paladin")
                {
                    Paladin paladin = new Paladin(name);
                    myList.Add(paladin);
                    counter++;
                }

                else if (type == "Rogue")
                {
                    Rogue rogue = new Rogue(name);
                    myList.Add(rogue);
                    counter++;
                }

                else if (type == "Warrior")
                {
                    Warrior warrior = new Warrior(name);
                    myList.Add(warrior);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }

            int bossDamage = int.Parse(Console.ReadLine());

            int sum = 0;

            foreach (var item in myList)
            {
                sum += item.Power;
                Console.WriteLine(item.CastAbility());
            }

            if (sum >= bossDamage)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
