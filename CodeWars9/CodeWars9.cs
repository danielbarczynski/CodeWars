System.Console.WriteLine(Kata.QueueTime(new int[] {10, 4, 3, 2}, 2));

public class Kata
{
    public static long QueueTime(int[] customers, int n)
    {
        Queue<int> queue1 = new();
        Queue<int> queue2 = new();
        long result = 0;

        if (n == 1)
        for (int i = 0; i < customers.Length; i++)
        {
            result += customers[i];
        } 
        else
        {
        queue1.Enqueue(customers[0]);
        queue2.Enqueue(customers[1]);
        if(queue1.Peek() < queue2.Peek())
        {
            queue1.Enqueue(customers[2]);
        }
        else
        {
            queue2.Enqueue(customers[2]);
        }

         for (int i = 3; i < customers.Length; i++)
        {
           if(queue1.Sum() < queue2.Sum())
           {
                queue1.Enqueue(customers[i]);
           }
           else
           {
                queue2.Enqueue(customers[i]);
           }
        } 
        }
         if(queue1.Sum() < queue2.Sum())
           {
                result += queue1.Sum();
           }
           else
           {
                 result += queue2.Sum();
           }
        return result;
    }
}
// mozliwosc 1: kupujacy 3 idzie do kolejki 1, jesli kupujacy 1 bedzie szybszy
// mozliwosc 2: kupujacy 3 idzie do kolejki 2, jesli kupujacy 2 bedzie szybszy