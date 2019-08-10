using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Item
    {
        public string Name { get; set; }
        public long Amount { get; set; }

        public Item(string name, long amount)
        {
            Name = name;
            Amount = amount;
        }
    }
} 
