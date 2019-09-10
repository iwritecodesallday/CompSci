using System;

public class example {
    public static void Main(string[] args) {
        // Suppose that i and j are both of type int
        Int32 i, j;
        for (i = 0, j = 0; i < 10; i++) {
            j +=i;
            Console.WriteLine(j);
        }
        Console.WriteLine("End \n");

        for (i = 0, j = 1; i < 10; i++)  {
            j += j;
            Console.WriteLine(j);
        }
        Console.WriteLine("End \n");

        for (j = 0; j < 10; j++) {
            j += j;
            Console.WriteLine(j);
        }
        Console.WriteLine("End \n");

        for (i = 0, j = 0; i < 10; i++) {
            j += j++;
            Console.WriteLine(j);
        }
        Console.WriteLine("End \n");
    }
}