using System;
using System.Linq;

// Write a program that reads in a sequence of integers and prints both the 
// integer that appears in a longest consecutive run and the length of that run.

public class longest
{
    public static void Main(String[] args)
    {
        int[] IntList = new int[args.Length];

        
        int this_longest_run = 0;

        for (int i = 0; i < args.Length; i++) {
            IntList[i] = int.Parse(args[i]);
            if(IntList[i - 1] == IntList[i]) {
                this_longest_run++;
            }
        }
        Console.WriteLine(this_longest_run);
    }
}