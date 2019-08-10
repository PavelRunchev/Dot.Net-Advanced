using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class StartUp
    {       
        static void Main()
        {
            HashSet<string> dataCarNumber = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string carNumber = arguments[1];
                if(command == "IN")
                {
                    dataCarNumber.Add(carNumber);
                }
                else if(command == "OUT")
                {
                    dataCarNumber.Remove(carNumber);
                }
            }

            if(dataCarNumber.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string item in dataCarNumber)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
