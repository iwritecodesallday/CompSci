using System;

public class AddInts {

    // This is a program that uses this Birds-Eye Model. It takes a command-line arguement n and produces an output
    // sequence of n random numbers between 0 and 1
    public static void Main(String[] args) {
        int n = int.Parse(args[0]);
        int sum = 0;

        for (int i = 0; i < n; i++) {
            int value = Convert.ToInt32(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine("Sum is " + sum);
    }
}