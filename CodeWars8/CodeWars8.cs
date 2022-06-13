using System;
using System.Linq;
string words = "is2 Thi1s T4est 3a";
System.Console.WriteLine(Kata.Order(words));

public static class Kata
{
  public static string Order(string words)
  {     
    string result = "";
    var splitted = words.Split(' ');
    var list = splitted.OrderByDescending(x=>Convert.ToInt32(x) > 0);
    list.ToList().ForEach(x=> result += x.ToString());
    return result;
  }
}