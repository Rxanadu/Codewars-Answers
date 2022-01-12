using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class GetMIddleCharacters
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5, 6, 7 };
            Console.WriteLine(arr[arr.Length/2]);

        }

        public static string GetMiddle(string s)
        {
            //Code goes here!
            string result = "";
            bool isEven = s.ToCharArray().Length % 2 == 0;

            if (isEven)
            {
                result = s.Substring((s.ToCharArray().Length / 2)- 1, 2);
            }
            else {
                result = s.Substring(s.ToCharArray().Length / 2, 1);
            }
            
            return result;

            //Alternative answer for single comment

            //return s.ToCharArray().Length % 2 == 0 ? s.Substring((s.ToCharArray().Length / 2)- 1, 2) :
            //s.Substring(s.ToCharArray().Length / 2, 1);
        }
    }
}
