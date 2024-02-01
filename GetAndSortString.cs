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
            int testCases = 0;
            testCases = int.Parse(Console.ReadLine());
            //input number dictates amount of loop calls = equivalent to amount of inputted test cases

            for (int j = 0; j < testCases; j++) //
            {
                string wordInput;
                int stringLength;
                wordInput = Console.ReadLine();
                stringLength = wordInput.Length;

                for (int wordIndex = 0; wordIndex < stringLength; wordIndex += 2)
                    //i += 2 syntax loops through string counting every other index starting from 0 (even indices)
                {
                    Console.Write(wordInput[wordIndex]);
                }

                Console.Write(" ");
                for (int wordIndex = 1; wordIndex < stringLength; wordIndex += 2)
                    // same logic as above, but starting index at 1 and still counting every 2nd from 1 (odd indices)
                {
                    Console.Write(wordInput[wordIndex]);
                }

                Console.WriteLine(); //when written here, force console to write a new set of sorted results to the next line
            }
        }
    }
}
