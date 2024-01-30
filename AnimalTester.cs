using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class AnimalTester
    {
        public static void Test()
        {
            Dog dog1 = new Dog("Rotti", 23, "Rottweiler", false);
            Cat cat1 = new Cat("Felix", 17, "Norwegian Forest Cat", false);

            Console.WriteLine("I have a dog, his name is " + dog1.Name + ", he is " + dog1.Age + " years old and is a " + dog1.Breed + ". \n\nI also" +
                              " have a cat. His name is " + cat1.Name + ", he is " + cat1.Age + ".");

            Console.ReadKey();
        }
    }
}
