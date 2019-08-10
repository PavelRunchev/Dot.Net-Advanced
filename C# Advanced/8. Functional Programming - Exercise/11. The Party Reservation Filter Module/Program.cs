using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main()
        {
            Action<string[]> printGuestsForParty = names => Console.WriteLine(string.Join(" ", names));

            string[] inputNamesForFilter = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<string> filterData = new List<string>();
            string inputFilter;
            while((inputFilter = Console.ReadLine()) != "Print")
            {
                string[] filterCommand = inputFilter.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = filterCommand[0];

                if(command == "Add filter")
                {
                    filterData.Add($"{filterCommand[1]};{filterCommand[2]}");
                }
                else if (command == "Remove filter")
                {
                    filterData.Remove($"{filterCommand[1]};{filterCommand[2]}");
                }
            }

            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);

            foreach (string currentFilter in filterData)
            {
                string[] filter = currentFilter.Split(';');
                string action = filter[0];
                string parameters = filter[1];

                switch(action)
                {
                    case "Starts with": inputNamesForFilter = inputNamesForFilter
                            .Where(n => !startsWithFilter(n, parameters)).ToArray();
                        break;
                    case "Ends with": inputNamesForFilter = inputNamesForFilter
                            .Where(n => !endsWithFilter(n, parameters)).ToArray();
                        break;
                    case "Length":
                        int param = int.Parse(parameters);
                        inputNamesForFilter = inputNamesForFilter
                            .Where(n => !lengthFilter(n, param)).ToArray();
                        break;
                    case "Contains": inputNamesForFilter = inputNamesForFilter
                            .Where(n => !containsFilter(n, parameters)).ToArray();
                        break;
                }
            }

            printGuestsForParty(inputNamesForFilter);
        }
    }
}
