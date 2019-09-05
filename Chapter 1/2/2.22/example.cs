using System;

class example
{
    public static void Main(string[] args)
    {
        // Write a program that takes three double command-line arguments
        double x = Double.Parse(args[0]);
        double v = Double.Parse(args[1]);
        double t = Double.Parse(args[2]);
        double g = 9.0665;

        Console.WriteLine(x + v * t - g * Math.Pow(t, 2) / 2);

    }
}