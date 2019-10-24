using System;

public class SelfAvoidingWalk
{
    public static void Main(string[] args)
    {
        // One
        Random ran = new Random();
        int n = int.Parse(args[0]);
        int trials = int.Parse(args[1]);
        int deadEnds = 0;
        int steps = 0;


        for (int t = 0; t < trials; t++)
        {
            Boolean[,] a = new Boolean[n, n];
            int x = n / 2, y = n / 2;


            while (x > 0 && x < n - 1 && y > 0 && y < n - 1)
            {
                a[x, y] = true;

                if (a[x - 1, y] && a[x + 1, y] && a[x, y - 1] && a[x, y + 1])
                {
                    deadEnds++;
                    break;
                }

                double r = ran.NextDouble();
                if (r < 0.25)
                {
                    if (!a[x + 1, y])
                    {
                        x++;
                    }
                }
                else if (r < 0.50)
                {
                    if (!a[x - 1, y])
                    {
                        x--;
                    }
                }
                else if (r < 0.75)
                {
                    if (!a[x, y + 1])
                    {
                        y++;
                    }
                }
                else if (r < 1.00)
                {
                    if (!a[x, y - 1])
                    {
                        y--;
                    }
                }
                steps++;
                // Console.WriteLine("{0}, {1}, {2}", x ,y, steps);
                
            }
            Console.WriteLine("{0}, {1}, {2}%", a[x, y], 100 * steps / n, 100 * deadEnds / trials );
            steps = 0;
        }
        Console.WriteLine("{0}% dead ends", 100 * deadEnds / trials);
        
    }
}