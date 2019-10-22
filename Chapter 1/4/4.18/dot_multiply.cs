using System;

public class dot_multiply
{
    public static void Main(string[] args)
    {

        Int32 m = 2, n = 3, p = 3, q = 3, i, j, k;
        Int32[,] a = {
            { 1, 4, 2 },
            { 2, 5, 1 }
        };
        Int32[,] b = {
            { 3, 4, 2 },
            { 3, 5, 7 },
            { 1, 2, 1 }
        };


        Console.WriteLine("Matrix One:");
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Matrix Two:");
        for (i = 0; i < p; i++)
        {
            for (j = 0; j < q; j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }
        if (n != p)
        {
            Console.WriteLine("Matrix multiplication not possible");
        }
        else
        {
            Int32[,] c = new Int32[m, q];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < q; j++)
                {
                    c[i, j] = 0;
                    for (k = 0; k < n; k++)
                    {
                        
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            Console.WriteLine("The product of the two matrices is :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}