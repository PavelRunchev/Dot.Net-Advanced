using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;
using System.Linq;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private readonly int indexAdd = 0;
        private List<string> collection;
        private List<int> indexAfterAddOperation;
        private List<string> resultAfterRemoveOperation;

        public AddRemoveCollection()
        {
            this.collection = new List<string>();
            this.indexAfterAddOperation = new List<int>();
            this.resultAfterRemoveOperation = new List<string>();
        }

        public void Add(string item)
        {
            this.collection.Insert(0, item);
            this.indexAfterAddOperation.Add(this.indexAdd);
        }

        public void Remove()
        {
            string item = this.collection[this.collection.Count - 1];
            this.collection.RemoveAt(this.collection.Count - 1);
            this.resultAfterRemoveOperation.Add(item);
        }

        public string IndexResult()
        {
            return String.Join(" ", this.indexAfterAddOperation);
        }

        public string removeResult()
        {
            return String.Join(" ", this.resultAfterRemoveOperation);
        }
    }
}
