using System;

public class example
{
    public static void Main(string[] args)
    {
        int n = 10;
        int[] a = new int[n];
        a[0] = 1;
        a[1] = 1;
        for (int i = 2; i < n; i++)
            Console.WriteLine(a[i] = a[i - 1] + a[i - 2]);
        // 1 + 1 = 2
        // 2 + 1 = 3
        // 3 + 2 = 5
        // 5 + 3 = 8
        // 8 + 5 = 13
        // 13 + 8 = 21
        // 21 + 13 = 34
        // 34 + 21 = 55
    }
    // Question:
    // Which value does the following code put in the array a[]?

    // Answer:
    // 
}