using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split(" ").ToArray();
                string model = inputCar[0];
                int engSpeed = int.Parse(inputCar[1]);
                int engPower = int.Parse(inputCar[2]);
                int cargoWeight = int.Parse(inputCar[3]);
                string cargoType = inputCar[4];

                //Create Engine
                Engine engine = new Engine(engSpeed, engPower);
                //Create Cargo
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                //Create list from Tires
                List<Tire> tires = new List<Tire>();

                //Adding tires properties in list collection
                for (int g = 5; g < inputCar.Length; g += 2)
                {
                    //adding in list from tires i create new object Tire width four 
                    tires.Add(new Tire(double.Parse(inputCar[g]), int.Parse(inputCar[g + 1])));
                }
                
                //create Car
                Car car = new Car(model, engine, cargo, tires);
                //add in list from cars
                cars.Add(car);
            }

            List<Car> outputCars = new List<Car>();
            string command = Console.ReadLine();
            if(command == "fragile")
            {
                outputCars = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(t => t.Tires.Any(p => p.Pressure < 1))
                    .ToList();
            }
            else if(command == "flamable")
            {
                outputCars = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
            }

            foreach (Car car in outputCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
