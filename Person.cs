using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
    }
}
