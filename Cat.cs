using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Cat : Animal
    {
        public Cat(string name, int age, string breed, bool isNeutered) : base(name, age, breed)
        {
            IsNeutered = isNeutered;
        }
        private bool IsNeutered { get; set; }
    }
}
