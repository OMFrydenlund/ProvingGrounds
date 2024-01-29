using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Dog : Animal
    {
        public string Breed;

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
    }
}
