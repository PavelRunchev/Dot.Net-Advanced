using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParty
{
    class StartUp
    {
        static void Main()
        {
            HashSet<string> dataReservation = new HashSet<string>();
            string input;
            while((input = Console.ReadLine()) != "PARTY")
            {
                dataReservation.Add(input);                
            }

            string reservation;
            while ((reservation = Console.ReadLine()) != "END")
            {
                dataReservation.Remove(reservation);
            }

            Console.WriteLine(dataReservation.Count());
            foreach (var item in dataReservation)
            {
                if (Char.IsDigit(item[0]))
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in dataReservation)
            {
                if (!Char.IsDigit(item[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
