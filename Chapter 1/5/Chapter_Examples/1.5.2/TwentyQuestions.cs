using System;

public class TwentyQuestions
{

    // This is a program that uses this Birds-Eye Model. It takes a command-line arguement n and produces an output
    // sequence of n random numbers between 0 and 1
    public static void Main(String[] args)
    {
        Random ran = new Random();
        int secret = 1 + (int) (ran.NextDouble() * 1000000);
        Console.Write(" I'm thinking of a number ");
        Console.WriteLine("between 1 and 1, 000, 000");
        int guess = 0;
        while (guess != secret)
        {
            Console.Write("Whats your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secret) Console.Write("You win! ");
            if (guess < secret) Console.Write("Too Low ");
            if (guess > secret) Console.Write("Too High ");
        }
    }
}