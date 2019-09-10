using System;

public class ten_hellos {
    public static void Main(string[] args) {
        Console.WriteLine("1st Hello");
        Console.WriteLine("2nd Hello");
        Console.WriteLine("3rd Hello");
        int i = 4;
        
        while (i <= 10) {
            Console.WriteLine(i + "th Hello");
            i = i + 1;
        }
    }
}