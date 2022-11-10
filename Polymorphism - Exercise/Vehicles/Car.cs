using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionCoefficient = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void Drive(double distance)
        {
            double result = distance * (this.FuelConsumption + AirConditionCoefficient);

            if (this.FuelQuantity >= result)
            {
                this.FuelQuantity -= result;

                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }

        }

        public override void Refuel(double liters)
        {
            if (liters > 0)
            {
                double availableSpace = this.TankCapacity - this.FuelQuantity;

                if (liters > availableSpace)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += liters;
                }
            }

            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
                        

        }
    }
}
