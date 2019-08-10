using System;

namespace BookShop
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string titleBook = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, titleBook, price);
                GoldenEditionBook editBook = new GoldenEditionBook(author, titleBook, price);
          
                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(editBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }
        }
    }
}
