using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations
{
    class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string Model
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
