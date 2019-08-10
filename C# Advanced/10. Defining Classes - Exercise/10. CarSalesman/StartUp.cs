using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int countEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countEngines; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string engModel = inputEngine[0];
                int engPower = int.Parse(inputEngine[1]);
                string engDisplacement = "n/a";
                string engEfficiency = "n/a";

                if (inputEngine.Length == 3)
                {
                    string token = inputEngine[2];
                    if (int.TryParse(token, out int num))
                    {
                        engDisplacement = num.ToString();
                    }
                    else
                    {
                        engEfficiency = token;
                    }
                }
                    
                if(inputEngine.Length == 4)
                {
                     engDisplacement = inputEngine[2];
                     engEfficiency = inputEngine[3];
                }
                    
                if(engines.Any(e => e.Model == engModel))
                {
                    Engine currentEngine = engines.FirstOrDefault(e => e.Model == engModel);
                    currentEngine.Power = engPower;
                    currentEngine.Displacement = engDisplacement;
                    currentEngine.Efficiency = engEfficiency;
                }
                else
                {
                    Engine engine = new Engine(engModel, engPower, engDisplacement, engEfficiency);
                    engines.Add(engine);
                } 
            }

            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = inputCar[0];
                string engine = inputCar[1];
                string weight = "n/a";
                string color = "n/a";
                if (inputCar.Length == 3)
                {
                    string token = inputCar[2];
                    if (int.TryParse(token, out int num))
                    {
                        weight = token;
                    }
                    else
                    {
                        color = token;
                    }
                }               
                else if(inputCar.Length == 4)
                {
                    weight = inputCar[2];
                    color = inputCar[3];
                }
                              
                Car car = new Car(model, engine, weight, color);
                cars.Add(car);                            
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Engine currentEngine = engines.FirstOrDefault(e => e.Model == car.Engine);
                Console.WriteLine($"  {currentEngine.Model}:");
                Console.WriteLine(currentEngine.ToString());
                Console.WriteLine(car.ToString());
            }
        }
    }
}
