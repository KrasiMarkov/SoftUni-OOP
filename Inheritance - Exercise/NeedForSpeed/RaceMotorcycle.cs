using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private double defaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel)
           : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => defaultFuelConsumption;

        public override void Drive(double kilometers)
        {
            double fuelAfterDrive = Fuel - kilometers * FuelConsumption;

            if (fuelAfterDrive >= 0)
            {
                Fuel = fuelAfterDrive;
            }
        }
    }
}
