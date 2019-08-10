

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private readonly double increase = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        { }

        public override double Increase()
        {
            return this.increase;
        }
    }
}
