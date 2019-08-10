using System;
using System.Collections.Generic;
using System.Text;
using FoodShortage.Interfaces;

namespace FoodShortage
{
    public class Robot : INames, IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Name = model;
            this.Id = id;
        }

        public string Name
        {
            get => model;
            private set => model = value;
        }

        public string Id
        {
            get => id;
            private set => id = value;
        }
    }
}
