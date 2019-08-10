using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        private static List<Person> peoples;
        private static List<Product> products;

        static void Main()
        {
            peoples = new List<Person>();
            products = new List<Product>();

            string[] personsInput = Console.ReadLine()
                .Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string person in personsInput)
            {
                string[] per = person.Split("=");
                string name = per[0];
                decimal money = decimal.Parse(per[1]);
                Person people = new Person(name, money);
                peoples.Add(people);
            }

            string[] productInput = Console.ReadLine()
                .Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);         
            foreach (string articule in productInput)
            {
                string[] arg = articule.Split("=");
                string name = arg[0];
                decimal cost = decimal.Parse(arg[1]);
                Product product = new Product(name, cost);
                products.Add(product);              
            }

            string commands;
            while((commands = Console.ReadLine()) != "END")
            {
                string[] arguments = commands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string personName = arguments[0];
                string productName = arguments[1];
                if(peoples.Any(p => p.Name == personName) && products.Any(prod => prod.Name == productName))
                {
                    Person currentPerson = peoples.FirstOrDefault(p => p.Name == personName);
                    Product currentProduct = products.FirstOrDefault(p => p.Name == productName);                   
                    Console.WriteLine(currentPerson.BuyProduct(currentProduct));
                }
            }

            //Print Person Collection
            foreach (Person p in peoples)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
