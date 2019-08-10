using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine
    {
        private AddCollection collection;
        private AddRemoveCollection addRemoveCollection;
        private MyList myList;

        public Engine()
        {
            this.collection = new AddCollection();
            this.addRemoveCollection = new AddRemoveCollection();
            this.myList = new MyList();
        }

        public void Run()
        {
            string[] input = Console.ReadLine().Split();
            int removeCountElements = int.Parse(Console.ReadLine());

            foreach (string item in input)
            {
                collection.Add(item);
                addRemoveCollection.Add(item);
                myList.Add(item);
            }

            for (int i = 0; i < removeCountElements; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            printOutput();         
        }

        private void printOutput()
        {
            //First Output Line -> print index
            Console.WriteLine(collection.Result());
            //Second Output Line -> print index
            Console.WriteLine(addRemoveCollection.IndexResult());
            //Third Output Line -> print index
            Console.WriteLine(myList.IndexResult());

            //Fourth Output Line -> print removed elements
            Console.WriteLine(addRemoveCollection.removeResult());
            //Fifth Output Line -> print removed elements
            Console.WriteLine(myList.RemoveResult());
        }
    }
}
