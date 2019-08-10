using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split(" ").ToArray();
                string model = inputCar[0];
                int fuel = int.Parse(inputCar[1]);
                double consumptionFor1Km = double.Parse(inputCar[2]);
                Car car = new Car(model, fuel, consumptionFor1Km);
                if(!cars.Any(c => c.Model == model))
                {
                    cars.Add(car);
                }
            }

            string drive;
            while((drive = Console.ReadLine()) != "End")
            {
                string[] tokens = drive.Split(" ").ToArray();
                if(tokens[0] == "Drive")
                {
                    string model = tokens[1];
                    int distance = int.Parse(tokens[2]);
                    var currentModel = cars.FirstOrDefault(c => c.Model == model);
                    if(currentModel != null)
                    {
                        currentModel.Drive(model, distance);
                    }
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Distance}");
            }
        }
    }
}
