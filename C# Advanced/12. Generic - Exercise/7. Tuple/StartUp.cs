using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            
            string[] firstInput = Console.ReadLine().Split();
            string firstName = firstInput[0];
            string lastName = firstInput[1];
            string address = firstInput[2];
            Tuple<string, string> tuple1 = new Tuple<string, string>($"{firstName} {lastName}", address);

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(name, litersOfBeer);

            string[] thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double doubleNumber = double.Parse(thirdInput[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(integer, doubleNumber);

            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}
