using System;
using System.Globalization;

namespace DateModifier
{
    class Program
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            DateModifier date = new DateModifier(input1, input2);
            date.Modifier();
        }
    }
}
