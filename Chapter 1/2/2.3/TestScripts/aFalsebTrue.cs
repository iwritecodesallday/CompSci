using System;
class aFalsebTrue
{
    public static void Main(string[] args)
    {
        Boolean a = false;
        Boolean b = true;
        Boolean result = (!(a && b) && (a || b)) || ((a && b) || !(a || b));

        if (result == true)
        {
            Console.WriteLine(result);
        }
    }
}