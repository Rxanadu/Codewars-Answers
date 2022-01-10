using System;

//Question: Disemvowel Trolls

public static class Kata
{
    public static string Disemvowel(string str)
    {
        char[] delimiterChars = {'a','e','i','o','u','A','E','I','O','U'};
      
        string[] splitArray = str.Split(delimiterChars);
      
        string result = "";
        
        for (int i = 0; i < splitArray.Length; i++){
          string word = splitArray[i];
          result += word;
        }
      
        return result;
    }
}