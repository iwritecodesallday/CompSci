using System;
class aTruebFalse
{
    public static void Main(string[] args)
    {
        Boolean a = true;
        Boolean b = false;
        Boolean result = (!(a && b) && (a || b)) || ((a && b) || !(a || b));

        if (result == true)
        {
            Console.WriteLine(result);
        }
    }
}