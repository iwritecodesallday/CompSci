using System;

class example_3 {
    public static void Main(string[] args) {
        int a = 2;
        Console.WriteLine(a);
        // 2
        Console.WriteLine(a = a * a);
        // 4
        Console.WriteLine(a = a * a);
        // 16
        Console.WriteLine(a = a * a);
        // 256
    }
}