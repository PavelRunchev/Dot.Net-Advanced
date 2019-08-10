using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int amountCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountCars; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
               
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                string[] tiresInput = parameters.Skip(5).ToArray();
                car.InitialTires(tiresInput);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1))
                    .ToList();
                PrintCars(fragile);
            }
            else
            {
                List<Car> flamable = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .ToList();

                PrintCars(flamable);
            }
        }

        public static void PrintCars(List<Car> output)
        {
            foreach (Car car in output)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
