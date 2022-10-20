using System;
using System.Linq;
using System.Collections.Generic;
namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {



            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Beast!")
                {
                    break;
                }

                string[] secondLine = Console.ReadLine().Split().ToArray();

                string name = secondLine[0];

                int age = int.Parse(secondLine[1]);

                string gender = secondLine[2];

                if (line == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);

                    if (cat.krasi == true)
                    {
                        continue;
                    }

                    Console.WriteLine(cat);

                }

                else if (line == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);

                    if (dog.krasi == true)
                    {
                        continue;
                    }

                    Console.WriteLine(dog);
                }

                else if (line == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);

                    if (frog.krasi == true)
                    {
                        continue;
                    }

                    Console.WriteLine(frog);
                }

                else if (line == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);

                    if (kitten.krasi == true)
                    {
                        continue;
                    }


                    Console.WriteLine(kitten);

                }

                else if (line == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);

                    if (tomcat.krasi == true)
                    {
                        continue;
                    }

                    Console.WriteLine(tomcat);
                }
            }



        }
    }
}
