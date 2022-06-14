using System;
using System.Linq;
string words = "is2 Thi1s T4est 3a";
Console.WriteLine(Kata.Order(words));


public static class Kata
{
  public static string Order(string words)
  {     
    string result = "";
        var splitted = words.Split(' ').ToList();

        for (int i = 0; i < 10; i++)
        {
            //if (splitted.Contains(i.ToString()))
            //{

            //}
            splitted.OrderBy(x => x.Contains(i.ToString()));
            
        }
        foreach (var item in splitted)
        {
            Console.WriteLine(item);
        }
       // list.ToList().ForEach(x => result += x);
        // var list = splitted.OrderBy(x=> x);
        //list.ToList().ForEach(x=> result += x);

        return result;
  }
}