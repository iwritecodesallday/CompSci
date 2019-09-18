using System;

public class Example
{
    public static void Main(string[] args)
    {
        // Write a program that, using one for loop and one if statement, prints integers from 1000, 2000 with 5 integers perline
        int i;
        for (i = 1000; i <= 2000; i++)
        {
            if (i % 5 == 0) Console.WriteLine("\n");
        }
        Console.WriteLine();
    }
}

// initialize another variable in a seperate statement
// int power = 1;

// declare and initialize a loop control variable
// for (int i = 0;
// loop-continuation condition
// i <= n;
// increment
// i++) {

// }