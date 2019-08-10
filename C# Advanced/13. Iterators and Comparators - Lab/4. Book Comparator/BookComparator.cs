using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title) == 0 
                ? y.Year.CompareTo(x.Year) 
                : x.Title.CompareTo(y.Title);
        }
    }
}
