using System;

//Question: You're a Square!

public class Kata
{
  public static bool IsSquare(int n)
  {
    //Your code goes here!
    bool result = true;
    
    if(n == 0){
      result = true;
    }else{
      result = n % Math.Sqrt(n) == 0 ? true : false;
    }
    
    return result;
  }
}