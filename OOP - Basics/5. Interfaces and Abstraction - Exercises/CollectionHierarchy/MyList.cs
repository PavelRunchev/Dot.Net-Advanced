using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;
using System.Linq;

namespace CollectionHierarchy
{
    public class MyList : IMyList
    {
        private readonly int indexAdd = 0;
        private List<string> collection;
        private List<int> indexAfterAddOperation;
        private List<string> resultAfterRemoveOperation;

        public MyList()
        {
            this.collection = new List<string>();
            this.indexAfterAddOperation = new List<int>();
            this.resultAfterRemoveOperation = new List<string>();
        }

        public void Add(string item)
        {
            this.collection.Insert(0, item);
            this.indexAfterAddOperation.Add(indexAdd);
        }

        public void Remove()
        {
            string item = this.collection[0];
            this.collection.RemoveAt(0);
            this.resultAfterRemoveOperation.Add(item);
        }

        public int Used()
        {
            return this.collection.Count();
        }

        public string IndexResult()
        {
            return String.Join(" ", this.indexAfterAddOperation);
        }

        public string RemoveResult()
        {
            return string.Join(" ", this.resultAfterRemoveOperation);
        }
    }
}
