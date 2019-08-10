using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models;

namespace VehiclesExtension.Core
{
    public class Engine
    {
        private Car car;
        private Truck truck;
        private Bus bus;

        public void Run()
        {            
            //Added default values in car, truck and bus!
            for (int i = 0; i < 3; i++)
            {
                string[] inputVehicle = Console.ReadLine().Split();
                string typeVehicle = inputVehicle[0];
                double vehicleFuelQuantity = double.Parse(inputVehicle[1]);
                double vehicleFuelConsumption = double.Parse(inputVehicle[2]);
                double vehicleTankCapacity = double.Parse(inputVehicle[3]);

                if (typeVehicle == "Car")
                    car = new Car(vehicleFuelQuantity, vehicleFuelConsumption, vehicleTankCapacity);
                else if (typeVehicle == "Truck")
                    truck = new Truck(vehicleFuelQuantity, vehicleFuelConsumption, vehicleTankCapacity);
                else if (typeVehicle == "Bus")
                    bus = new Bus(vehicleFuelQuantity, vehicleFuelConsumption, vehicleTankCapacity);
            }

            int countCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCommands; i++)
            {
                try
                {
                    string[] inputCommand = Console.ReadLine().Split();
                    string command = inputCommand[0];
                    string typeVehicle = inputCommand[1];

                    if (command == "Refuel")
                    {
                        double liters = double.Parse(inputCommand[2]);
                        AddedRefuel(typeVehicle, liters);
                    }
                    else if (command == "Drive")
                    {
                        double distance = double.Parse(inputCommand[2]);
                        CalcDistance(typeVehicle, distance);
                    }
                    else if (command == "DriveEmpty" && typeVehicle == "Bus")
                    {
                        double distance = double.Parse(inputCommand[2]);
                        if (bus.AirConditioner() == "on")
                            bus.AirConditionerOff();

                        Console.WriteLine(bus.Drive(distance));
                    }
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            printRemainingFuel();
        }

        private void printRemainingFuel()
        {
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }

        private void CalcDistance(string typeVehicle, double distance)
        {
            if (typeVehicle == "Car")
            {
                Console.WriteLine(car.Drive(distance));
            }
            else if (typeVehicle == "Truck")
            {
                Console.WriteLine(truck.Drive(distance));
            }
            else if (typeVehicle == "Bus")
            {
                if (bus.AirConditioner() == "off")
                    bus.AirConditionerOn();

                Console.WriteLine(bus.Drive(distance));
            }
        }

        private void AddedRefuel(string typeVehicle, double liters)
        {
            if(typeVehicle == "Car")
            {
                car.Refueling(liters);
            }
            else if(typeVehicle == "Truck")
            {
                truck.Refueling(liters);
            }
            else if(typeVehicle == "Bus")
            {
                if (bus.AirConditioner() == "off")
                    bus.AirConditionerOn();

                bus.Refueling(liters);
            }
        }
    }
}
