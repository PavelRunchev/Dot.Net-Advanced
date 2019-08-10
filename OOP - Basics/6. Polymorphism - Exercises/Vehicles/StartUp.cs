using System;
using System.Collections.Generic;
using Vehicles.Models;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 0; i < 2; i++)
            {
                string[] inputVehicle = Console.ReadLine().Split();
                string typeVehicle = inputVehicle[0];
                double fuelQuantity = double.Parse(inputVehicle[1]);
                double fuelConsumption = double.Parse(inputVehicle[2]);
                if(typeVehicle == "Car")
                {
                    Car car = new Car(fuelQuantity, fuelConsumption);
                    vehicles.Add(car);
                }
                else if(typeVehicle == "Truck")
                {
                    Truck truck = new Truck(fuelQuantity, fuelConsumption);
                    vehicles.Add(truck);
                }
            }

            int countCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCommands; i++)
            {
                string[] inputCommand = Console.ReadLine().Split();
                string command = inputCommand[0];
                string typeVehicle = inputCommand[1];
                var currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == typeVehicle);

                if (command == "Drive" && currentVehicle != null)
                {
                    double distance = double.Parse(inputCommand[2]);
                    Console.WriteLine(currentVehicle.Driving(distance));
                }
                else if(command == "Refuel" && currentVehicle != null)
                {
                    double fuel = typeVehicle == "Truck" 
                        ? double.Parse(inputCommand[2]) * 0.95 
                        : double.Parse(inputCommand[2]);

                    currentVehicle.Refueling(fuel);
                }
            }

            printVehiclesFuel(vehicles);
        }

        private static void printVehiclesFuel(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
