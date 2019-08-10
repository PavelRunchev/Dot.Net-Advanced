using System;
using System.Linq;
using System.Text;


namespace Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        internal protected string FirstName
        {
            get => firstName;
            set
            {
                if(!Char.IsUpper(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");

                if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");

                firstName = value;
            }
        }

        internal protected string LastName
        {
            get => lastName;
            set
            {
                if (!Char.IsUpper(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");

                if (value.Length <= 2)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");

                lastName = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            return builder
                .AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .ToString();
        }
    }
}
