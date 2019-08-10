using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class StartUp
    {
        static void Main()
        {
            string[] inputVehicles = Console.ReadLine().Split().ToArray();
            Stack<string> waitingVehicles = new Stack<string>(inputVehicles.Reverse());
            Stack<string> servedVehicles = new Stack<string>();

            string inputCommands;
            while ((inputCommands = Console.ReadLine()) != "End")
            {
                string[] commands = inputCommands.Split("-");
                string command = commands[0];
                switch (command)
                {
                    case "Service":
                        if(waitingVehicles.Count > 0)
                        {
                            string carModel = waitingVehicles.Pop();
                            servedVehicles.Push(carModel);
                            Console.WriteLine($"Vehicle {carModel} got served.");
                        }                       
                        break;
                    case "CarInfo": Console.WriteLine(waitingVehicles.Contains(commands[1]) 
                        ? "Still waiting for service." : "Served.");
                        break;
                    case "History": Console.WriteLine(String.Join(", ", servedVehicles));
                        break;
                }
            }

            if(waitingVehicles.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", waitingVehicles)}");
            }

            Console.WriteLine($"Served vehicles: {String.Join(", ", servedVehicles)}");
        }      
    }
}
