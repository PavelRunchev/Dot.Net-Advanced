using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> store;
        private int index;

        public ListyIterator(params T[] arr)
        {
            this.store = new List<T>(arr);
            this.index = 0;
        }

        public bool HasNext()
        {
            if (this.index == this.store.Count - 1)
                return false;

            return true;
        }

        public bool Move()
        {
            if (this.index + 1 > this.store.Count - 1)
                return false;

            this.index++;
            return true;
        }

        public void Print()
        {
            if(this.store.Count == 0 || this.index < 0 || this.index > this.store.Count - 1)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.store[this.index]);
        }
    }
}
