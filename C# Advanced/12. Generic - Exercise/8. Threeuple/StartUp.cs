using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string firstName = firstInput[0];
            string lastName = firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];
            if (firstInput.Length > 4)
            {
                firstInput = firstInput.Skip(4).ToArray();
                foreach (var partTown in firstInput)
                    town += " " + partTown;
            }
            
            Tuple<string, string, string> tuple1 = new Tuple<string, string, string>($"{firstName} {lastName}", address, town);

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            string drunk = secondInput[2] == "drunk" ? "True" : "False";
            Tuple<string, int, string> tuple2 = new Tuple<string, int, string>(name, litersOfBeer, drunk);

            string[] thirdInput = Console.ReadLine().Split();
            string accountName = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(accountName, balance, bankName);

            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}
