using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class User
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public User() { }
        public User (string name, string country, int age, int weight)
        {
            Name = name;
            Country = country;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Country: {Country}, Age: {Age}, Weight: {Weight}";
        }
    }
}
