using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            data = new List<T>();
        }

        public int Count
        {
            get => this.data.Count;
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            if (this.data.Count == 0)
                throw new IndexOutOfRangeException("The collection is empty!");

            T element = this.data[this.data.Count - 1];            
            this.data.RemoveAt(this.data.Count - 1);

            return element;
        }
    }
}
