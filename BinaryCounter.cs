using System;
using System.Collections.Generic;

namespace BinaryCounter
{
    class BinaryCounter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountBits(1234);
        }

        public static int CountBits(int n)
        {
            string toBinaryString = Convert.ToString(n, 2);
            char[] binaryChars = toBinaryString.ToCharArray();

            int binary1Count = 0;

            foreach (char charr in binaryChars) {
                if (charr.Equals('1')) {
                    binary1Count++;
                }
            }

            return binary1Count;
        }
    }
}
