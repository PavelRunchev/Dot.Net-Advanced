using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private readonly double increase = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        { }

        public override double Increase()
        {
            return this.increase;
        }

        public override void Refueling(double refuel)
        {
            if (refuel <= 0)
                throw new ArgumentException("Fuel must be a positive number");

            if (refuel + this.FuelQuantity > this.TankCapacity)
                throw new ArgumentException($"Cannot fit {refuel} fuel in the tank");

           this.FuelQuantity += refuel * 0.95;
        }
    }
}
