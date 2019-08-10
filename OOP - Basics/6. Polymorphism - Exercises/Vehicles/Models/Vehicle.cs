using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set => fuelQuantity = value;
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }

        public virtual double Increase()
        {
            return 0;
        }

        public string Driving(double distance)
        {
            double neededFuel = (this.FuelConsumption + Increase()) * distance;
            if (neededFuel > this.fuelQuantity)
                return $"{this.GetType().Name} needs refueling";

            this.fuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public void Refueling(double fuel)
        {
            this.fuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{base.GetType().Name}: {this.fuelQuantity:f2}";
        }
    }
}
