using System;

// Explain how to use Program 1.2.3 to find the square root of a number

class explain {
    public static void Main(string[] args) {
        // Variables b and c
        double b = Double.Parse(args[0]);
        double c = Double.Parse(args[1]);

        // Expression to be squared
        double discriminant = b*b - 4.0*c;

        // Square Root Function
        double d = Math.Sqrt(discriminant);
        // Square Root Function

        Console.WriteLine((-b + d) / 2.0);
        Console.WriteLine((-b - d) / 2.0);
    }
}