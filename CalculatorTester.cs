using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class CalculatorTester
    {
        public static void RunTests()
        {
            Calculator calculator = new Calculator(0);

            Console.WriteLine(calculator.Add(3, 8));
            Console.WriteLine("Result of addition is: " + calculator.GetResult());

            Console.WriteLine(calculator.Subtract(2, 14));
            Console.WriteLine("Result of subtraction is: " + calculator.GetResult());

            Console.WriteLine(calculator.Multiply(4, 9));
            Console.WriteLine("Result of multiplication is: " + calculator.GetResult());

            Console.WriteLine(calculator.Divide(10, 5));
            Console.WriteLine("Result of division is: " + calculator.GetResult());
        }
    }
}
