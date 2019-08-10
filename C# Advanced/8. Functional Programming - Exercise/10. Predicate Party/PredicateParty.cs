using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            Action<List<string>> printGuests = partyGuests =>
            {
                if (partyGuests.Count > 0)
                    Console.WriteLine($"{string.Join(", ", partyGuests)} are going to the party!");
                else
                    Console.WriteLine("Nobody is going to the party!");
            };

            Func<List<string>, string, string, List<string>> doubleName = (names, command, str) =>
            {
                List<string> list = new List<string>();
                for (int i = 0; i < names.Count; i++)
                {
                    if(command == "StartsWith")
                    {
                        string name = names[i];
                        if (name.StartsWith(str))
                        {
                            list.Add(name);
                            list.Add(name);
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                    else if(command == "EndsWith")
                    {
                        string name = names[i];
                        if (name.EndsWith(str))
                        {
                            list.Add(name);
                            list.Add(name);
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                    else if(command == "Length")
                    {
                        string name = names[i];
                        int length = int.Parse(str);
                        if(name.Length <= length)
                        {
                            list.Add(name);
                            list.Add(name);
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                }
                return list;
            };

            Func<List<string>, string, string, List<string>> removeName = (names, command, str) =>
            {
                List<string> list = new List<string>();
                for (int i = 0; i < names.Count; i++)
                {
                    if (command == "StartsWith")
                    {
                        string name = names[i];
                        if (name.StartsWith(str))
                        {
                            continue;
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                    else if (command == "EndsWith")
                    {
                        string name = names[i];
                        if (name.EndsWith(str))
                        {
                            continue;
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                    else if (command == "Length")
                    {
                        string name = names[i];
                        int length = int.Parse(str);
                        if (name.Length <= length)
                        {
                            continue;
                        }
                        else
                        {
                            list.Add(name);
                        }
                    }
                }
                return list;
            };

            List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;
            while((commands = Console.ReadLine()) != "Party!")
            {
                string[] arguments = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string subCommand = arguments[1];
                string str = arguments[2];
                if(command == "Double")
                {
                    guests = doubleName(guests, subCommand, str);
                }
                else if(command == "Remove")
                {
                    guests = removeName(guests, subCommand, str);
                }
            }

            printGuests(guests);
        }
    }
}
