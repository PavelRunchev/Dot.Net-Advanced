using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Tuple<TItem1, TItem2, TItem3>
    {
        private TItem1 item1;
        private TItem2 item2;
        private TItem3 item3;

        public Tuple(TItem1 item1, TItem2 item2, TItem3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public TItem1 Item1
        {
            get => this.item1;
            set => this.item1 = value;
        }

        public TItem2 Item2
        {
            get => this.item2;
            set => this.item2 = value;
        }

        public TItem3 Item3
        {
            get => this.item3;
            set => this.item3 = value;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
