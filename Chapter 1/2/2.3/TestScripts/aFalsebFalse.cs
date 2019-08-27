using System;
// Suppose that a and b are boolean variables

class bothFalse
{
    public static void Main(string[] args)
    {
        Boolean a = false;
        Boolean b = false;
        Boolean result = (!(a && b) && (a || b)) || ((a && b) || !(a || b));

        if (result == true)
        {
            Console.WriteLine(result);
        }
    }
}