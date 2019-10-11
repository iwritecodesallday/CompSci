// Write code fragments to create a two-dimentional array b[][] that is a copy 
// of the existing two-dimentional array a[][], under each of the following assumptions:
// a. a[][] is a square
// b. a[][] is a rectangle
// c. a[][] may be ragged

// Your solution to b should work for a, and your solution to c should work for
//  both b and a, and our code should get progressively more complicated.

using System;

public class rectange_array_copy
{
    public static void Main(string[] args)
    {

        // Create a rectangle array
        String [,] rectangle = new String[2,3] {
            {"Cat", "Cat", "Cat"},
            {"Dog", "Dog", "Dog"}
        };
        String [,] newRectange = new String[2,3];
        // rectangle Array
        for (Int16 i = 0; i < 2; i++) {
            for (Int16 j = 0; j < 3; j++) {
                newRectange[i, j] = rectangle[i, j];
                Console.WriteLine("rectange[{0}, {1}] = {2}", i, j, rectangle[i, j]);
                Console.WriteLine("newRectange[{0}, {1}] = {2}", i, j, newRectange[i, j]);

            }
        }
    }
}