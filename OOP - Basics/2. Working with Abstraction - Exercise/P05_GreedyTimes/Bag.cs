using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P05_GreedyTimes
{
    public class Bag
    {
        private long capacity;
        private Dictionary<string, List<Item>> items;
        private long totalSum;

        public Bag(long capacity)
        {
            this.Capacity = capacity;
            this.Items = new Dictionary<string, List<Item>>();
            this.TotalSum = 0;
        }

        public long Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        public Dictionary<string, List<Item>> Items
        {
            get => items;
            set => items = value;
        }

        public long TotalSum
        {
            get => totalSum;
            set => totalSum = value;
        }

        public long GetGoldSum()
        {
            if(this.Items.ContainsKey("Gold"))
                return this.Items["Gold"].Sum(i => i.Amount);

            return 0;
        }

        public long GetGemsSum()
        {
            if(this.Items.ContainsKey("Gem"))
                return this.items["Gem"].Sum(a => a.Amount);

            return 0;
        }

        public long GetCashSum()
        {
            if(this.Items.ContainsKey("Cash"))
                return this.items["Cash"].Sum(a => a.Amount);

            return 0;
        }

        public void AddItem(string itemName, long amount)
        {
            Item item = new Item(itemName, amount);

            if (itemName.ToLower() == "gold")
            {
                if (this.Capacity >= this.TotalSum + amount 
                    && this.Capacity >= this.GetGoldSum() + amount)
                {
                    if(!this.Items.ContainsKey("Gold"))
                        this.Items.Add("Gold", new List<Item>());

                    if (!this.Items["Gold"].Any(a => a.Name == "Gold"))
                        this.Items["Gold"].Add(item);
                    else
                        this.Items["Gold"][0].Amount += amount;

                    this.TotalSum += amount;
                }
            }
            else if(itemName.Length >= 4 && itemName.ToLower().EndsWith("gem"))
            {
                if (this.Capacity >= this.TotalSum + amount 
                    && this.GetGoldSum() >= GetGemsSum() + amount)
                {
                    if (!this.Items.ContainsKey("Gem"))
                        this.Items.Add("Gem", new List<Item>());

                    if (this.Items["Gem"].Any(a => a.Name == itemName))
                    {
                        Item currentItem = this.Items["Gem"].FirstOrDefault(p => p.Name == itemName);
                        currentItem.Amount += amount;
                    }
                    else
                    {
                        this.Items["Gem"].Add(item);
                    }
        
                    this.TotalSum += amount;
                }
            }
            else if (itemName.Length == 3)
            {
                if(this.Capacity >= this.TotalSum + amount 
                    && this.GetGemsSum() >= this.GetCashSum() + amount)
                {
                    if (!this.Items.ContainsKey("Cash"))
                        this.Items.Add("Cash", new List<Item>());

                    if(this.Items["Cash"].Any(a => a.Name == itemName))
                    {
                        Item currentItem = this.Items["Cash"].FirstOrDefault(p => p.Name == itemName);
                        currentItem.Amount += amount;
                    }
                    else
                    {
                        this.Items["Cash"].Add(item);
                    }
                  
                    this.TotalSum += amount;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            var sortedItems = this.Items
                .OrderByDescending(i => i.Value.Sum(a => a.Amount))
                .ToDictionary(k => k.Key, v => v.Value.ToList());

            foreach (var type in sortedItems)
            {
                    builder.AppendLine($"<{type.Key}> ${this.Items[type.Key].Sum(a => a.Amount)}");
                    foreach (Item item in type.Value.OrderByDescending(k => k.Name).ThenBy(v => v.Amount))
                    {                       
                            if (item.Name == "Gold")
                                builder.AppendLine($"##{item.Name} - {item.Amount}");
                            else
                                builder.AppendLine($"##{item.Name} - {item.Amount}");                                          
                    }             
            }

            return builder.ToString().TrimEnd();
        }
    }
}
