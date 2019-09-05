using System;

class example_2 {
    public static void Main(string[] args) {
        Boolean a = true;
        // True
        Console.WriteLine(a);
        // False
        Console.WriteLine(a = !a);
        // True
        Console.WriteLine(a = !a);
        // False
        Console.WriteLine(a = !a);
    }
}