using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.authors = new List<string>(authors);
        }

        public string Title
        {
            get => this.title;
            private set => this.title = value;
        }

        public int Year
        {
            get => this.year;
            private set => year = value;
        }

        public IReadOnlyCollection<string> Authors
        {
            get => this.authors.AsReadOnly();
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if(result == 0)
                return this.Title.CompareTo(other.Title);           

            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
