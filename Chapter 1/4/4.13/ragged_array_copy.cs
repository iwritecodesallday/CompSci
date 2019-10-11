// Write code fragments to create a two-dimentional array b[][] that is a copy 
// of the existing two-dimentional array a[][], under each of the following assumptions:
// a. a[][] is a square
// b. a[][] is a rectangle
// c. a[][] may be ragged

// Your solution to b should work for a, and your solution to c should work for
//  both b and a, and our code should get progressively more complicated.

using System;

public class ragged_array_copy
{
    public static void Main(string[] args)
    {

        // Create a ragged array
        Int32[][] jaggedArray = new Int32[3][];
        
        for (Int32 i = 0; i < jaggedArray.Length; i++) {
            Console.WriteLine(jaggedArray[i][i]);
        }

        Console.WriteLine(jaggedArray.Length);
    }
}