using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Collection<T> : IEnumerable<T>
    {
        private Stack<T> store;

        public Collection()
        {
            this.store = new Stack<T>();
        }

        public Stack<T> Store
        {
            get => this.store;
        }

        public void Pop()
        {
            if (this.Store.Count() == 0)
            {
                throw new ArgumentException("No elements");
            }

            this.store.Pop();
        }

        public void Push(T[] elements)
        {
            foreach (T el in elements)
            {
                this.store.Push(el);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T el in this.store)
            {
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
