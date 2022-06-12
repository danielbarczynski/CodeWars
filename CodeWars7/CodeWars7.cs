System.Console.WriteLine(new Kata().Min(new []{-52, 56, 30, 29, -54, 0, -110}));
System.Console.WriteLine(new Kata().Max(new []{-52, 56, 30, 29, -54, 0, -110}));

public class Kata
{
  public int Min(int[] list)
  {
    return list.Min();
  }
  
  public int Max(int[] list)
  {
    return list.Max();
  }
}