using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    internal class ArrayTest
    {
        public ArrayTest()
        {
            PrintReverseArray();
        }

        public static void PrintReverseArray()
        {
            Console.WriteLine("How many numbers does your input consist of? ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Type five single digit numbers, followed by a space each: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int l = arr.Count - 1;
            for (int i = l; i >= 0; i--)
            {
                Console.Write(arr[i]);

                if (i > 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
