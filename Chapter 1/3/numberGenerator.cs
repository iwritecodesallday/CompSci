using System;

public class num_generator
{
    public static void Main(string[] args)
    {
        int i;
        string r = "";

        Random random = new Random();
        for (i = 1; i < 11; i++)
        {
            r += random.Next(0, 9).ToString();
        }
        Console.WriteLine(r);
    }
}