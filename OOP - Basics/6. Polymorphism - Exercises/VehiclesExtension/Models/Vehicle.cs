using System;
using VehiclesExtension.Interfaces;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double tankCapacity = 0;
        private double fuelQuantity = 0;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;           
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Fuel must be a positive number");

                if (value > this.TankCapacity)
                    fuelQuantity = 0;
                else
                    fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }

        public double TankCapacity
        {
            get => tankCapacity;
            set => tankCapacity = value;
        }

        public virtual double Increase()
        {
            return 0;
        }

        public string Drive(double distance)
        {
            double neededFuel = (this.fuelConsumption + this.Increase()) * distance;
            if (neededFuel > this.FuelQuantity)
                throw new ArgumentException($"{this.GetType().Name} needs refueling");

            this.FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refueling(double refuel)
        {
            if (refuel <= 0)
                throw new ArgumentException("Fuel must be a positive number");

            if (refuel + this.FuelQuantity > this.TankCapacity)
                throw new ArgumentException($"Cannot fit {refuel} fuel in the tank");

            this.fuelQuantity += refuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
