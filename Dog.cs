using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Dog : Animal
    {
        public Dog(string name, int age, string breed, bool hasTail) : base(name, age, breed)
        {
            HasTail = hasTail;
        }

        public bool HasTail { get; set; }
    }
}
