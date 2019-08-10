using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private readonly double increase = 1.4;
        private string airConditioner = "on";

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        { }

        public override double Increase()
        {
            return this.airConditioner == "on" ? this.increase : 0;
        }

        public string AirConditioner()
        {
            return this.airConditioner;
        }

        public void AirConditionerOff()
        {
            this.airConditioner = "off";
        }

        public void AirConditionerOn()
        {
            this.airConditioner = "on";
        }
    }
}
