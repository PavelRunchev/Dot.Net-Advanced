using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class StartUp
    {
        static Pizza pizza;

        static void Main()
        {
            try
            {
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] commands = input.Split();
                    string command = commands[0];
                    if (command == "Pizza")
                    {
                        pizza = new Pizza(commands[1]);
                    }
                    else if (command == "Dough")
                    {
                        string type = commands[1];
                        string baking = commands[2];
                        int weight = int.Parse(commands[3]);
                        Dough dough = new Dough(type, baking, weight);
                        pizza.Dough = dough;
                    }
                    else if (command == "Topping")
                    {
                        string typeTopping = commands[1];
                        int weightTopping = int.Parse(commands[2]);
                        pizza.AddTopping(new Topping(typeTopping, weightTopping));
                    }
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
