using System;

class math
{
    public static void Main(string[] args)
    {
        string input_string = args[0];
        double converted_string = Convert.ToDouble(input_string);

        double sin_square = Math.Sin(converted_string) * Math.Sin(converted_string);
        double cos_square = Math.Cos(converted_string) * Math.Cos(converted_string);

        double final_double = sin_square + cos_square;
        
        Console.WriteLine(final_double);


    }
}