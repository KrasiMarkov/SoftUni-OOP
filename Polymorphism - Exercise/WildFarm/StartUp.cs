using System;
using System.Linq;
using System.Collections.Generic;
namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string[] animal = Console.ReadLine().Split().ToArray();

                if (animal[0] == "End")
                {
                    break;
                }

                string[] food = Console.ReadLine().Split().ToArray();
                string foodType = food[0];
                int foodQuantity = int.Parse(food[1]);

                Food food1 = null;

                if (foodType == "Vegetable")
                {
                    food1 = new Vegetable(foodQuantity);
                }

                else if (foodType == "Fruit")
                {
                    food1 = new Fruit(foodQuantity);
                }

                else if (foodType == "Meat")
                {
                    food1 = new Meat(foodQuantity);
                }

                else if (foodType == "Seeds")
                {
                    food1 = new Seeds(foodQuantity);
                }



                if (animal[0] == "Hen")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    double wingSize = double.Parse(animal[3]);

                    Hen hen = new Hen(name, weight, wingSize);
                    Console.WriteLine(hen.ProduceSound());
                    hen.AddFood(food1);
                    animals.Add(hen);
                    

                }

                else if (animal[0] == "Owl")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    double wingSize = double.Parse(animal[3]);

                    Owl owl = new Owl(name, weight, wingSize);
                    Console.WriteLine(owl.ProduceSound());
                    owl.AddFood(food1);
                    animals.Add(owl);
                    
                }

                else if (animal[0] == "Mouse")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];

                    Mouse mouse = new Mouse(name, weight, livingRegion);
                    Console.WriteLine(mouse.ProduceSound());
                    mouse.AddFood(food1);
                    animals.Add(mouse);
                    
                }

                else if (animal[0] == "Dog")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];

                    Dog dog = new Dog(name, weight, livingRegion);
                    Console.WriteLine(dog.ProduceSound());
                    dog.AddFood(food1);
                    animals.Add(dog);
                    
                }

                else if (animal[0] == "Cat")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];
                    string breed = animal[4];

                    Cat cat = new Cat(name, weight, livingRegion, breed);
                    Console.WriteLine(cat.ProduceSound());
                    cat.AddFood(food1);
                    animals.Add(cat);
                    
                }

                else if (animal[0] == "Tiger")
                {
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];
                    string breed = animal[4];

                    Tiger tiger = new Tiger(name, weight, livingRegion, breed);
                    Console.WriteLine(tiger.ProduceSound());
                    tiger.AddFood(food1);
                    animals.Add(tiger);
                    
                }
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
