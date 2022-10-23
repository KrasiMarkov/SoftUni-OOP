using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {

            this.Fuel = fuel;
            this.HorsePower = horsePower;

        }

      

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelAfterDrive = Fuel - kilometers * FuelConsumption;

            if (fuelAfterDrive >= 0)
            {
                Fuel = fuelAfterDrive;
            }
        }


    }
}
