foreach (var x in LiczbyCalkowiteNaprzemiennie(13))
{
    Console.Write($"{x} ");
}

static IEnumerable<int> LiczbyCalkowiteNaprzemiennie(int n)
{
    List<int> numbers = new List<int>(){0};

    if (n < 0)
    {
        throw new Exception();
    }

    else
    {
        int positiveNumber = 0;
        int negativeNumber = 0;

        for (int i = 0; i < n; i++)
        {
            positiveNumber++;
            negativeNumber = -1 - positiveNumber;

            if(positiveNumber % 2 != 0)
                numbers.Add(positiveNumber);

            if (negativeNumber % 2 == 0)
                numbers.Add(negativeNumber);           
        }

        if (n % 2 != 0)
        {
            int last = numbers[++positiveNumber];
            numbers.Remove(last);
        }

        return numbers;
    }
}
