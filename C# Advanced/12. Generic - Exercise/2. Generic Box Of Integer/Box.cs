using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (T text in this.data)
            {
                builder.AppendLine($"{text.GetType().FullName}: {text}");
            }

            return builder.ToString();
        }
    }
}
