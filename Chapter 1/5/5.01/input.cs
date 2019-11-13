using System;
using System.Linq;

public class input {
    public static void Main(string[] args) {

        int[] IntList = new int[args.Length];
        
        for (int i = 0; i < args.Length; i++) {
            IntList[i] = int.Parse(args[i]);
        }

        int Max = IntList.Max();
        int Min = IntList.Min();

        Console.Write("Max: {0}, Min: {1}", Max, Min);
    }
}