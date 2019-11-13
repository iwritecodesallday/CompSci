using System;

public class RangeFilter {
    public static void Main(String[] args) {
        int lo = int.Parse(args[0]);
        int hi = int.Parse(args[1]);

        while(!string.IsNullOrWhiteSpace(Console.ReadLine())) {
            int value = int.Parse(Console.ReadLine());
            if (value >= lo && value <= hi) {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}