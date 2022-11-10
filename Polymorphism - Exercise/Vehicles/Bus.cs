﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {

        private const double AirConditionCoefficient = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
          : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }
        public override void Drive(double distance)
        {

            double result = distance * (this.FuelConsumption + AirConditionCoefficient);

            if (this.FuelQuantity >= result)
            {
                this.FuelQuantity -= result;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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

        public void DriveWithoutPeople(double distance)
        {
            double result = distance * this.FuelConsumption;

            if (this.FuelQuantity >= result)
            {
                this.FuelQuantity -= result;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
