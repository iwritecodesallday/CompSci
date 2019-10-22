using System;

public class example {
    public static void Main(string[] args) {
        Int32 i, j, k;
        for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    
                    for (k = 0; k < 5; k++)
                    {
                        Console.WriteLine("Numbers {0}, {1}, {2}", i, j, k);
                    }
                }
            }
    }
}