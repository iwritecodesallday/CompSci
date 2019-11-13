using System;
using System.Linq;

// Write a program that reads in a sequence of integers and prints both the 
// integer that appears in a longest consecutive 
// run and the length of that run.

public class longest
{
    public static void Main(String[] args)
    {
        int[] IntList = new int[args.Length];

        int longest_run = 0;
        int this_run = 0;
        int consecutive = 0;

        for (int i = 0; i < args.Length; i++)
        {
            IntList[i] = int.Parse(args[i]);
            for (int j = 1; j < args.Length; j++)
            {
                Console.WriteLine("{0} : {1}", IntList[i], IntList[j]);

                if (IntList[i] == IntList[j])
                {
                    this_run++;
                    consecutive = IntList[i];
                }

                if (IntList[i] != IntList[j])
                {
                    if (longest_run < this_run)
                    {
                        longest_run = this_run;
                    }
                    this_run = 0;
                }
            }
        }
        Console.WriteLine("Run: {0} with Consecutive: {1}", longest_run + 1, consecutive);
    }
}