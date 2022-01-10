using System;
using System.Text;

//Question: Convert string to camel case

public class Kata
{
  public static string ToCamelCase(string str)
  {
    char[] delimiterChars = { '-', '_' };

            string[] words = str.Split(delimiterChars);

            string result = "";

            for (int i = 0; i < words.Length; i++) {

                string word = words[i];

                if (i != 0)
                {
                    word = Char.ToUpperInvariant(word[0]) + word.Substring(1).ToLowerInvariant();
                }

                result += word;
            }

            return result;
  }
  
}