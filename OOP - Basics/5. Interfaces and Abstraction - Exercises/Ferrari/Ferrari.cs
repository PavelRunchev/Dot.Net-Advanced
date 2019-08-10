using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : Car, ICar
    {
        private string driverName;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        public string DriverName
        {
            get => driverName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot must be empty!");

                driverName = value;
            }
        }

        public override string ToString()
        {
            return $"{base.Model}/{base.Brakes()}/{this.Gas()}/{this.driverName}";
        }
    }
}
