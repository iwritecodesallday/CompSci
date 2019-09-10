using System;
public class Flip {
    public static void Main(string[] args) {
        Random random = new Random(1);
        double randomNumber = random.NextDouble();
        Console.WriteLine(randomNumber);

        if (randomNumber < 0.5) Console.WriteLine("heads");
        else Console.WriteLine("Tails");
    }
}