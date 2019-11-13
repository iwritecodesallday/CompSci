using System;

public class RandomSeq {

    // This is a program that uses this Birds-Eye Model. It takes a command-line arguement n and produces an output
    // sequence of n random numbers between 0 and 1
    public static void Main(String[] args) {
        int n = int.Parse(args[0]);
        Random ran = new Random();

        for ( int i = 0; i < n; i++) {
            Console.WriteLine(ran.NextDouble());
        }
    }
}