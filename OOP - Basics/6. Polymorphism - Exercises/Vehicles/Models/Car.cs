
namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private double increase = 0.9;

        public Car(double quantity, double fuelConsumption)
            : base(quantity, fuelConsumption)
        { }

        public override double Increase()
        {
            return this.increase;
        }
    }
}
