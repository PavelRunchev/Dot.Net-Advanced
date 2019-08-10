using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public List<T> Data
        {
            get => this.data;
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T firstItem = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstItem;
        }

        public void CountMethod(T item)
        {
            this.data = this.data.Where(e => e.CompareTo(item) > 0).ToList();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (T item in this.data)
            {
                builder.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
