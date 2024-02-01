using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    internal class GetAndSortString
    {
        public static void InputAndPrintSorted()
        {
            int t = 0;
            t = int.Parse(Console.ReadLine());

            for (int j = 0; j < t; j++) 
            {
                string s;
                int n;
                s = Console.ReadLine();
                n = s.Length;

                for (int i = 0; i < n; i += 2)
                {
                    Console.Write(s[i]);
                }

                Console.Write(" ");
                for (int i = 1; i < n; i += 2)
                {
                    Console.Write(s[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
