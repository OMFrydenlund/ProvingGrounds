using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    class Calculator
    {
        private double result;

        public Calculator(double initialValue)
        {
            result = initialValue;
        }

        public double Add(double operand1, double operand2) {

                result = operand1 + operand2;
                return result;
        }

        public double Subtract(double operand1, double operand2) {

            result = operand1 - operand2;
            return result;
        }

        public double Multiply(double operand1, double operand2) {

            result = operand1 * operand2;
            return result;
        }

        public double Divide(double divisor1, double divisor2)
        {
            if (divisor2 != 0)
            {
                result = divisor1 / divisor2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            return result;
        }

        public double GetResult()
        {
            return result;
        }
    }
}
