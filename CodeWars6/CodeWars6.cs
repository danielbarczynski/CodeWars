﻿using System.Collections.Generic;
using System.Linq;

Console.WriteLine(Kata.GetUnique(new[] { 11, 11, 11, 11, 12 }));

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var arr = numbers.ToArray();
        try
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != arr[i + 1] && arr[i] != arr[i + 2])
                {
                    return arr[i];
                }
            }
        }
        catch (Exception)
        {
            for (int i = 2; i < arr.Length; i++)
            {

                if (arr[i] != arr[i - 1] && arr[i] != arr[i - 2])
                {
                    return arr[i];
                }
            }
        }

        return arr[0];
    }
}