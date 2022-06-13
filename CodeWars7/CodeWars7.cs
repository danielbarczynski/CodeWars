using System.Linq;
using System;

System.Console.WriteLine(Kata.Solution(20));
System.Console.WriteLine(Kata.Solution2(20));
public static class Kata
{
  public static int Solution(int value)
  {
    int sum = 0;
     if ( value < 0)
     {
    return 0;
    }
    
    for (int i = 0; i < value; i++)
    {
      if (i % 5 == 0 || i % 3 == 0){
        sum += i;
      }
    }
    
    return sum; 
  }
  // Slower and doesn't recognize negative numbers
  public static int Solution2(int n)
  {
   return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
   }
   
}
// 3,5,6,9,10,12,15,18 = 78