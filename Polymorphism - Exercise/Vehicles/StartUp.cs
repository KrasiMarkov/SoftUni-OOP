using System;
using System.Linq;
using System.Collections.Generic;
namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split().ToArray();

            string[] truckData = Console.ReadLine().Split().ToArray();

            string[] busData = Console.ReadLine().Split().ToArray(); 

            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));

            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));

            Bus bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[1] == "Car")
                {
                    if (command[0] == "Drive")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }

                }

                else if (command[1] == "Truck")
                {
                    if (command[0] == "Drive")
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }

                }

                else if (command[1] == "Bus")
                {
                    if (command[0] == "Drive")
                    {
                        bus.Drive(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                    else if (command[0] == "DriveEmpty")
                    {
                        bus.DriveWithoutPeople(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
