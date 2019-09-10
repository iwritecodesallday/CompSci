using System;

public class powersOfTwo
{
    public static void Main(string[] args)
    {
        Int32 n = Int32.Parse(args[0]);
        Int32 power = 1;
        Int32 i = 0;
        while (i <= n)
        {
            Console.WriteLine(i + " " + power);
            power = 2 * power;
            i = i + 1;
        }
    }
}