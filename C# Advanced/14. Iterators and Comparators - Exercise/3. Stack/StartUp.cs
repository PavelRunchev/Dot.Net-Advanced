using System;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StartUp
    {        
        static void Main()
        {
            Collection<int> store = new Collection<int>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] commands = input.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    string command = commands[0];

                    if (command == "Push")
                    {
                        store.Push(commands.Skip(1).Select(int.Parse).ToArray());
                    }
                    else if (command == "Pop")
                    {
                        store.Pop();
                    }
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }             
            }

            //Print twice elements in store!
            if(store.Store.Count > 0)
            {
                StringBuilder firstElements = new StringBuilder();
                StringBuilder secondElements = new StringBuilder();
                foreach (int el in store)
                {
                    firstElements.AppendLine(el.ToString());
                    secondElements.AppendLine(el.ToString());
                }

                Console.WriteLine($"{firstElements}{secondElements}".TrimEnd());
            }
        }
    }
}
