using System;

public class CouponCollector
{
    public static void Main(string[] args)
    {

        Int32 n = Int32.Parse(args[0]);

        Boolean[] isCollected = new Boolean[n];

        Int32 count = 0;

        Int32 distinct = 0;

        while (distinct < n)
        {

            Random t = new Random();

            Int32 r = (Int32)(t.Next(n));

            count++;

            if (!isCollected[r])
            {

                distinct++;
                isCollected[r] = true;

            }
        }

        Console.WriteLine(count);
    }
}