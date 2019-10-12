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
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };
        
        for (Int32 i = 0; i < jaggedArray.Length; i++) {
            for (Int32 j = 0; j < jaggedArray[i].Length; j++)
                Console.WriteLine(jaggedArray[i][j]);
        }
    }
}