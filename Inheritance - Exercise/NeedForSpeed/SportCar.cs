﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private double defaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
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
