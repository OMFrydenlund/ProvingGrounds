using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Cat : Animal
    {
        public string Color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }
    }
}
