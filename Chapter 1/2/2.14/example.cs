using System;

// Write a program that takes two positive integers as command-line arguments and prints true if either evenly divides the other

class example
{
    public static void Main(string[] args)
    {

        // Two Positive Integers
        int p1_int = Int32.Parse(args[0]);
        int p2_int = Int32.Parse(args[1]);

        // Check if they're Positive
        if (p1_int > 0 && p2_int > 0)
        {
            // Divide Route 1 Check
            int check_1 = p1_int % p2_int;
            // Divide Route 2 Check
            int check_2 = p2_int % p1_int;

            if (check_1 == 0 || check_2 == 0)
            {
                Console.WriteLine("True");
            }
            else if (!(check_1 == 0 || check_2 == 0))
            {
                Console.WriteLine("False");
            }
            Console.WriteLine(check_1);
            Console.WriteLine(check_2);
        }
        // If Number isn't Positive
        else if (p1_int <= 0 || p2_int <= 0)
        {
            Console.WriteLine("Error, not a positive input");
        }
    }
}