// Write code fragments to create a two-dimentional array b[][] that is a copy 
// of the existing two-dimentional array a[][], under each of the following assumptions:
// a. a[][] is a square
// b. a[][] is a rectangle
// c. a[][] may be ragged

// Your solution to b should work for a, and your solution to c should work for
//  both b and a, and our code should get progressively more complicated.

using System;

public class square_array_copy
{
    public static void Main(string[] args)
    {

        // Create a square array
        String [,] square = new String[2,2] {
            {"Cat", "Cat"},
            {"Dog", "Dog"}
        };
        String [,] newSquare = new String[2,2];
        // Square Array
        for (Int16 i = 0; i < 2; i++) {
            for (Int16 j = 0; j < 2; j++) {
                newSquare[i, j] = square[i, j];
                Console.WriteLine("square[{0}, {1}] = {2}", i, j, square[i, j]);
                Console.WriteLine("newSquare[{0}, {1}] = {2}", i, j, newSquare[i, j]);
            }
        }
    }
}