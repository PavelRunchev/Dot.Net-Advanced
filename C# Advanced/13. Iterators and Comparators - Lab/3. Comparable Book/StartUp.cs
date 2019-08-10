using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "Gearge Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book BookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, BookThree);
            foreach (Book book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
}
