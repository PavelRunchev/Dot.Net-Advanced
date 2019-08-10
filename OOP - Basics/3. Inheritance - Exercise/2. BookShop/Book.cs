using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        internal string Author
        {
            get => author;
            set
            {
                string[] authorName = value.Split();                  
                if (authorName.Length > 1 && char.IsDigit(authorName[1][0]))
                    throw new ArgumentException("Author not valid!");
                 
                author = value;
            }
        }

        internal string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                title = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");

                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            return build.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}")
                .ToString()
                .TrimEnd();
        }
    }
}
