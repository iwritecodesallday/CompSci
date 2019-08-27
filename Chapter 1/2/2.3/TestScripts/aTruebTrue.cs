using System;

class bothTrue
{
    public static void Main(string[] args)
    {
        Boolean a = true;
        Boolean b = true;
        Boolean result = (!(a && b) && (a || b)) || ((a && b) || !(a || b));

        if (result == true)
        {
            Console.WriteLine(result);
        }
    }
}