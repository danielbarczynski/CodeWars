// Welcome to the city

Console.WriteLine(Kata.SayHello(new string[] {"John", "Smith"}, "Phoenix", "Arizona"));
Console.WriteLine(Kata.SayHello(new string[] {"John", "Bruce", "Smith"}, "Phoenix", "Arizona"));

Console.WriteLine(Kata.SayHello2(new string[] {"John", "Smith"}, "Phoenix", "Arizona"));
Console.WriteLine(Kata.SayHello2(new string[] {"John", "Bruce", "Smith"}, "Phoenix", "Arizona"));

public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        string fullName = "";
        for (int i = 0; i < name.Length; i++)
        {
            fullName += name[i];
            if(i != name.Length - 1)
            {
                fullName += " ";
            }
        }

        return $"Hello, {fullName}! Welcome to {city}, {state}!";
    }
    public static string SayHello2(string[] name, string city, string state) =>
    $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
}