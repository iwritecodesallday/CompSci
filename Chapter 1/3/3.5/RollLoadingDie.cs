using System;

public class example
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        double chances = random.NextDouble();
        int roll = 0;

        if (chances >= 0.25)
        {
            Console.WriteLine(chances + ": This is the weighted end");
            roll = 6;
            Console.WriteLine(roll);
        }
        else if (chances <= 0.25)
        {
            Console.WriteLine(chances + ": Randomly Choosing 1, 2, 3, 4, 5");
            roll = random.Next(1, 5);
            Console.WriteLine(roll);
        }
        else {
            Console.WriteLine("Error");
        }
    }
}