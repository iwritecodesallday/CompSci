using System;

// The Exclusive OR Operator ^ for boolean operands is defined to be
// true if they are different, false if they are the same. Give a truth table for this function

class truthTable {
    public static void Main(string[] args) {
        // One or the Other But not Both: Exclusive OR
        
        string input_option_1 = args[0];
        string input_option_2 = args[1];

        if(input_option_1 == "true" && input_option_2 == "true") {
            Console.WriteLine("False");
        }
        else if(input_option_1 == "true" && input_option_2 == "false") {
            Console.WriteLine("True");
        }

        else if (input_option_1 == "false" && input_option_2 == "false") {
            Console.WriteLine("True");
        }
        else if (input_option_1 == "false" && input_option_2 == "true") {
            Console.WriteLine("False");
        }
    }
}