using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            Queue<string> cars = new Queue<string>();
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int carsPassed = 0;
            string inputCommand;
            while ((inputCommand = Console.ReadLine()) != "END")
            {
                if (inputCommand == "green")
                {
                    int durationGreenLight = greenLight;
                    while(durationGreenLight > 0 && cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        if(durationGreenLight - car.Length >= 0)
                        {
                            durationGreenLight -= car.Length;
                            carsPassed++;
                        }
                        else
                        {
                            string carParts = car.Substring(durationGreenLight);
                            if(carParts.Length > 0)
                            {
                                if (freeWindow > carParts.Length)
                                    freeWindow = carParts.Length;

                                carParts = carParts.Substring(freeWindow);
                            }

                            if (carParts.Length > 0)
                            {
                                char carPart = carParts[0];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {carPart}.");
                                return;
                            }
                            else
                            {
                                carsPassed++;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(inputCommand);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}
