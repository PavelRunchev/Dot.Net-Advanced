using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        private string model;
        private double fuel;
        private double consumption;
        private int distance;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public double Fuel
        {
            get => this.fuel;
            set => this.fuel = value;
        }

        public double Consumption
        {
            get => this.consumption;
            set => this.consumption = value;
        }

        public int Distance
        {
            get => this.distance;
            set => this.distance = value;
        }

        public void Drive(string model, int distance)
        {
            double neededLitersForMoves = distance * this.Consumption;
            if(this.fuel >= neededLitersForMoves)
            {
                this.fuel -= neededLitersForMoves;
                this.distance += distance;
            } 
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
        }
    }
}
