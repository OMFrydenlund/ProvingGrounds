using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    public class PersonTester
    {
        public static void DisplayDetails()
        {
            Person firstPerson = new Person("Miguel", "Frydenlund", 34);
            Console.WriteLine("The first person's name is " + firstPerson.FirstName + " " + firstPerson.LastName +
                              ", and he is " + firstPerson.Age + " years old.");
        }
    }
}
