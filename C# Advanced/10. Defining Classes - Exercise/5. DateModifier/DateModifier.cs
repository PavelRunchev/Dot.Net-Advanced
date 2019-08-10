using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DateModifier
{
    public class DateModifier
    {
        private string date1;
        private string date2;

        public string Date1 {
            get { return this.date1; }
            set { this.date1 = value; }
        }

        public string Date2
        {
            get { return this.date2; }
            set { this.date2 = value; }
        }

        public void Modifier()
        {
            DateTime firstDate = DateTime.ParseExact(this.date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(this.date2, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan differenceDate = firstDate -  secondDate;
            Console.WriteLine(Math.Abs(differenceDate.TotalDays));
        }

        public DateModifier(string date1, string date2)
        {
            this.Date1 = date1;
            this.Date2 = date2;
        }
    }
}
