using System;

public class Average
{
    public static void Main(string[] args)
    {
        double sum = 0.0;
        int n = 0;
        
        while (!string.IsNullOrWhiteSpace(Console.ReadLine()))
        {
            double value = double.Parse(Console.ReadLine());
            sum += value;
            n++;
        }
        Console.Write(sum);
        Console.Write(n);

        double average = sum / n;
        Console.WriteLine("Average is " + average);
    }
}