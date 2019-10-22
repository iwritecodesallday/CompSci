using System;

// Write a program that declares, creates, and initializes an array a[] of length 1000 and accesses a[1000]. 
// Does your program compile? What happens when you run it?

// because 1000 doesn't exist.

public class example {
    public static void Main(string[] args) {
        int n = 1000;
        double[] a;
        a = new double[n];
        for (int i = 0; i < n; i++) {
            a[i] = 0.0;
        }
        Console.WriteLine(a[999]);
        // 999 Exists
        Console.WriteLine(a[1000]);
    }
}