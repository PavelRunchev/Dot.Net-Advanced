using System;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main()
        {
            Box<double> box = new Box<double>();
            int countElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < countElements; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double comparisonElement = double.Parse(Console.ReadLine());
            box.CountMethod(comparisonElement);

            Console.WriteLine(box.Data.Count);
        }
    }
}
