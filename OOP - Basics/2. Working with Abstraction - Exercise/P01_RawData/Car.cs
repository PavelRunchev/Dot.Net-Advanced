using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.cargo = cargo;
            this.tires = new List<Tire>();
        }

        public string Model
        {
            get => model;
            set => model =  value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Cargo Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public List<Tire> Tires
        {
            get => tires;
        }

        public void InitialTires(string[] tiresInput)
        {
            for (int i = 0; i < tiresInput.Length; i+= 2)
            {
                double pressure = double.Parse(tiresInput[i]);
                int age = int.Parse(tiresInput[i + 1]);
                Tire tire = new Tire(age, pressure);
                this.tires.Add(tire);
            }
        }
    }
}
