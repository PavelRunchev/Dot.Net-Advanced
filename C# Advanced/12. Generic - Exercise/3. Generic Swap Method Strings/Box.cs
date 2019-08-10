using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
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

        public void Swap(int firstIndex, int secondIndex)
        {
            T firstItem = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstItem;
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
