// Descending order

int num = 254342;
Console.WriteLine(Kata.DescendingOrder(num));
Console.WriteLine(Kata.DescendingOrder2(num));
Console.WriteLine(Kata.DescendingOrder3(num));

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        string text = num.ToString();
        var arr = text.ToArray();
        List<char> list = new List<char>();

        for (int i = 0; 
        
        {
            list.Add(arr[i]);           
        }

        var q1 = list.OrderByDescending(x => x);
        q1.ToList();
        string empty = " ";

        foreach (var x in q1)
        {
            empty += x;
        }

        return Convert.ToInt32(empty);
    }

    public static int DescendingOrder2(int num)
    {
        return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }

    public static int DescendingOrder3(int num)
    {
        string text = num.ToString();
        var orderedText = text.OrderByDescending(x => x);
        string empty = String.Concat(orderedText);

        return Convert.ToInt32(empty);
    }
}