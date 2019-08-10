using System;
using System.Text;

namespace CustomLinkedList
{
    class Program
    {
        static void Main()
        {
            var doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddLast("string");
            doublyLinkedList.AddLast("12312");
            doublyLinkedList.AddLast("1243213");
            doublyLinkedList.AddLast("test");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
