using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.authors = authors.ToList();
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

        public List<string> Authors
        {
            get => this.authors;
        }
    }
}
