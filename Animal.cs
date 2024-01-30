using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Animal
    {
        public Animal(string name, int age, string breed) 
        {
            Name = name;
            Age = age;
            Breed = breed;

        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }
    }
}
