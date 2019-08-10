using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person person = new Person("Gosho", 35);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
