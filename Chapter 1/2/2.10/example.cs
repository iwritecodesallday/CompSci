using System;

class example
{
    public static void Main(string[] args)
    {
        // Suppose that a variable a is declared as int a = 2147483647
        //int a = 2147483647;
        int a = Int32.MaxValue;
        // 
        Console.WriteLine(a);
        // 
        Console.WriteLine(a + 1);
        // 
        Console.WriteLine(2 - a);
        // 
        Console.WriteLine(-2 - a);
        // 
        Console.WriteLine(2 * a);
        // 
        Console.WriteLine(4 * a);
        Console.WriteLine(Math.Pow(2, 31));
        // 

    }
}