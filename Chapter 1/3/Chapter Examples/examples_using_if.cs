using System;

class Example
{
    public static void Main(string[] args)
    {
        absolute_value();

    }

    public static void absolute_value(string[] args)
    {
        Int32 x = Int32.Parse(args[0]);
        if (x < 0) x = -x;
        Console.WriteLine(x);
    }

    public static void small_to_larger(string[] args)
    {
        Int32 x = Int32.Parse(args[0]);
        Int32 y = Int32.Parse(args[1]);
        if (x > y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }

    public static void max_of_x_and_y(string[] args)
    {
        Int32 x = Int32.Parse(args[0]);
        Int32 y = Int32.Parse(args[1]);

        if (x > y) max = x;
        else max = y;
    }

    public static void err_check_for_div_operator(string[] args) {
        if (den == 0) Console.WriteLine("Division By Zero");
        else Console.WriteLine("Quotient = " + num/den);
    }

    public static void err_check_quad_formula(string[] args) {
        double discriminant = b * b - 4.0*c;
        if (discriminant < 0.0) {
            Console.WriteLine("No Real Roots");
        } else {
            Console.WriteLine((-b + Math.Sqrt(discriminant)) / 2.0);
            Console.WriteLine((-b - Math.Sqrt(discriminant)) / 2.0);
        }
    }
}