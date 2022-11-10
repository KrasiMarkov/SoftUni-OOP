using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            
        }

        
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value <= this.tankCapacity)
                {
                    this.fuelQuantity = value;
                }
                else
                {
                    this.fuelQuantity = 0;
                }
                
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value;
            }
        }

        

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }



        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);

    }
}
