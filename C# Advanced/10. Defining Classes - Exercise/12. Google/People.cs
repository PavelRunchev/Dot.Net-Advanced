using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class People
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Children> children;
        private Car car;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Children> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public People(string name, Car car)
        {
            this.Name = name;
            this.Car = car;
        }

        public People(string name, Company company)
        {
            this.Name = name;
            this.Company = company;
        }

        public People(string name, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Pokemons = pokemons;
        }

        public People(string name, List<Parent> parents)
        {
            this.Name = name;
            this.Parents = parents;
        }

        public People(string name, List<Children> children)
        {
            this.Name = name;
            this.Children = children;
        }

        private string PokemonsToString(List<Pokemon> pokemons)
        {
            string result = String.Empty;
            foreach (var p in pokemons)
            {
                result += $"\n{p.ToString()}";
            }
            return result;
        }

        private string ParentsToString(List<Parent> parents)
        {
            string result = String.Empty;
            foreach (var par in parents)
            {
                result += $"\n{par.ToString()}";
            }
            return result;
        }

        private string ChildrenToString(List<Children> children)
        {
            string result = String.Empty;
            foreach (var child in children)
            {
                result += $"\n{child.ToString()}";
            }
            return result;
        }

        public override string ToString()
        {
            string name = this.name != null ? $"{this.name}" : "";
            string company = this.company != null ? $"\n{this.company.ToString()}" : "";
            string car = this.car != null ? $"\n{this.car.ToString()}" : "";
            string pokemon = this.pokemons != null ? $"{PokemonsToString(this.pokemons)}" : "";
            string parents = this.parents != null ? $"{ParentsToString(this.parents)}" : "";
            string children = this.children != null ? $"{ChildrenToString(this.children)}" : "";

            return $"{name}" +
                $"\nCompany:{company}" +
                $"\nCar:{car}" +
                $"\nPokemon:{pokemon}" +
                $"\nParents:{parents}" +
                $"\nChildren:{children}";
        }
    }
}
