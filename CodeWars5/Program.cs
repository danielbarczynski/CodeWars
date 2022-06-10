Kata.ArrayDiff3(new int[] { 1, 2, 4, 5}, new int[] { 1, 1, 3 });

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> list = new();
        for (int i = 0; i < a.Length; i++)
        {
            if (!a.Contains(b[i]))
            {
                list.Add(a[i]);
            }
        }
        var c = list.ToArray();
        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine(c[i]);
        }
        return c;
    }

    public static int[] ArrayDiff2(int[] a, int[] b)
    {
        var c = a.ToList().Except(b.ToList());

        foreach (var item in c)
        {
            Console.WriteLine(item);
        }

        return c.ToArray();
    }

    public static int[] ArrayDiff3(int[] a, int[] b)
    {
        for (int i = 0; i < b.Length; i++)
        {
            if (!a.ToList().Exists(a => a.Equals(b[i])))
            {
                Console.WriteLine("Y");
            }
        }

        

        return a;
    }
}