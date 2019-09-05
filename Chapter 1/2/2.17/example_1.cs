using System;

// Give the value of the variable a after the execution of each of the following sequences of statements

class Example_1 {
    public static void Main(string[] args) {
        int a = 1;
        Console.WriteLine(a);
        // 2
        Console.WriteLine(a = a + a);
        // 4
        Console.WriteLine(a = a + a);
        // 8
        Console.WriteLine(a = a + a);
    }
}