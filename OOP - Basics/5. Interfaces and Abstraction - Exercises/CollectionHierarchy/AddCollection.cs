using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollection
    {
        private int indexAdd = 0;
        private List<string> collection;
        private List<int> indexAddColection;

        public AddCollection()
        {
            this.collection = new List<string>();
            this.indexAddColection = new List<int>();
        }

        public void Add(string item)
        {
            this.collection.Add(item);
            this.indexAddColection.Add(this.indexAdd++);
        }

        public string Result()
        {
            return String.Join(" ", this.indexAddColection);
        }
    }
}
