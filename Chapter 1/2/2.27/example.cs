using System;

class example
{
    public static void Main(string[] args)
    {
        // Write a program that takes two interger command line args
        int m = Int32.Parse(args[0]);
        int d = Int32.Parse(args[1]);
        // and prints true if day d of the month m is between 3/20 and 6/20, false otherwise

        Boolean result = false;
        // If Month is 3 and Day is over 20 (3/20)

        // If Month is 3, 4, 5, or 6
        if (m >= 3 && m <= 6)
        {
            // Month 3 after day 20
            if (m == 3 && d >= 20)
            {
                result = true;
            }
            else if (m == 3 && d < 20)
            {
                result = false;
            }
            
            // Month 6 before day 20

            if (m == 6 && d <= 20)
            {
                result = true;
            }
            else if (m == 6 && d > 20)
            {
                result = false;
            } else if(m == 4 && d <= 30 ) {
                result = true;
            }
        }
        // If Month is less than 3 or greater than 6
        else if (m < 3 || m > 6)
        {
            result = false;
        }
        Console.WriteLine(result);
    }
}