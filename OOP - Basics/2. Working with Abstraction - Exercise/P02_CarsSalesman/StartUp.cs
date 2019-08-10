using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_CarsSalesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = inputEngine[0];
                int power = int.Parse(inputEngine[1]);

                int displacement = -1;

                if (inputEngine.Length == 3 && int.TryParse(inputEngine[2], out displacement))
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (inputEngine.Length == 3)
                {
                    string efficiency = inputEngine[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
                else if (inputEngine.Length == 4)
                {
                    string efficiency = inputEngine[3];
                    engines.Add(new Engine(model, power, int.Parse(inputEngine[2]), efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] inputCar = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = inputCar[0];
                string engineModel = inputCar[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                int weight = -1;

                if (inputCar.Length == 3 && int.TryParse(inputCar[2], out weight))
                {
                    cars.Add(new Car(model, engine, weight));
                }
                else if (inputCar.Length == 3)
                {
                    string color = inputCar[2];
                    cars.Add(new Car(model, engine, color));
                }
                else if (inputCar.Length == 4)
                {
                    string color = inputCar[3];
                    cars.Add(new Car(model, engine, int.Parse(inputCar[2]), color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
