
namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double increase = 1.6;

        public Truck(double quantity, double fuelConsumption)
            : base(quantity, fuelConsumption)
        { }

        public override double Increase()
        {
            return this.increase;
        }
    }
}
