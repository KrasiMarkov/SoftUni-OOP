using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditionCoefficient = 1.6;

        private const double PercentageKeepedFuel = 95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void Drive(double distance)
        {
            double result = distance * (this.FuelConsumption + AirConditionCoefficient);

            if (this.FuelQuantity >= result)
            {
                this.FuelQuantity -= result;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
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
                    double result = liters * (PercentageKeepedFuel / 100);

                    this.FuelQuantity += result;
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            


        }
    }
}
