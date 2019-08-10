using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get => this.horsePower;
            set => this.horsePower = value;
        }

        public double CubicCapacity
        {
            get => this.cubicCapacity;
            set => this.cubicCapacity = value;
        }
    }

    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year
        {
            get => this.year;
            set => this.year = value;
        }

        public double Pressure
        {
            get => this.pressure;
            set => this.pressure = value;
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get => this.make;
            set => this.make = value;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public int Year
        {
            get => this.year;
            set => this.year = value;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public Engine Engine
        {
            get => this.engine;
            set => this.engine = value;
        }

        public Tire[] Tires
        {
            get => this.tires;
            set => this.tires = value;
        }

        public void Drive(double distance)
        {
            bool isContinue = this.FuelQuantity - (distance * this.FuelConsumption / 100) >= 0;
            if (isContinue)
                this.FuelQuantity -= distance * (this.FuelConsumption / 100);
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            StringBuilder builder = new StringBuilder();
            builder
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"Year: {this.Year}")
                .Append($"Fuel: {this.FuelQuantity:F2}L");

            return builder.ToString();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            return builder
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"Year: {this.Year}")
                .AppendLine($"HorsePowers: {this.Engine.HorsePower}")
                .Append($"FuelQuantity: {this.FuelQuantity}")
                .ToString();
        }
    }

    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> dataTires = new List<Tire[]>();
            List<Engine> dataEngines = new List<Engine>();
            List<Car> cars = new List<Car>();


            //Fill all input tires in List collection!
            string inputTires;
            while ((inputTires = Console.ReadLine()) != "No more tires")
            {
                double[] arguments = inputTires
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                Tire[] tire = new Tire[4];
                int index = 0;
                for (int i = 0; i < arguments.Length; i += 2)
                {
                    int year = (int)arguments[i];
                    double pressure = arguments[i + 1];
                    tire[index] = new Tire(year, pressure);                  
                    index++;
                }

                dataTires.Add(tire);
            }

            string inputEngine;
            while ((inputEngine = Console.ReadLine()) != "Engines done")
            {
                string[] arguments = inputEngine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horserPower = int.Parse(arguments[0]);
                double cubicCapacity = double.Parse(arguments[1]);
                Engine engine = new Engine(horserPower, cubicCapacity);
                dataEngines.Add(engine);
            }

            string inputCar;
            while ((inputCar = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = inputCar.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Tire[] tires = dataTires[tiresIndex];
                Engine engine = dataEngines[engineIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                cars.Add(car);
            }

            Console.WriteLine();
            List<Car> specialCars = cars
                .Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower >= 330)
                .Where(c => c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10)
                .ToList();

            foreach (Car car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car.ToString());
            }
        }
    }
}
