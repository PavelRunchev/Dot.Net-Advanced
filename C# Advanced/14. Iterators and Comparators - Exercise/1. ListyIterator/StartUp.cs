using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        private static ListyIterator<string> store;

        static void Main()
        {            
             string input;
             while ((input = Console.ReadLine()) != "END")
             {
                    try
                    {
                        string[] arguments = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string command = arguments[0];

                        if (command == "Create")
                        {
                            string[] arr = arguments.Skip(1).ToArray();
                            store = new ListyIterator<string>(arr);
                        }
                        else if (command == "Print")
                        {
                            store.Print();
                        }
                        else if (command == "HasNext")
                        {
                            Console.WriteLine(store.HasNext());
                        }
                        else if (command == "Move")
                        {
                            Console.WriteLine(store.Move());
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
             }       
        }
    }
}
