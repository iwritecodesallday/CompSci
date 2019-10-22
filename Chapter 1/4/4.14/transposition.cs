// Write code fragments to create a two-dimentional array b[][] that is a copy 
// of the existing two-dimentional array a[][], under each of the following assumptions:
// a. a[][] is a square
// b. a[][] is a rectangle
// c. a[][] may be ragged

// Your solution to b should work for a, and your solution to c should work for
//  both b and a, and our code should get progressively more complicated.

using System;

public class transposition
{
    public static void Main(string[] args)
    {
        Int32 [][] sheet = new Int32[3][];
        sheet[0] = new Int32 [] { 99, 98, 92, 94, 99, 90, 76, 92, 97, 89 };
        sheet[1] = new Int32 [] { 85, 57, 77, 32, 34, 46, 59, 66, 71, 29 };
        sheet[2] = new Int32 [] { 98, 78, 76, 11, 22, 54, 88, 89, 24, 38 };

        Int32 a = sheet.Length;
        Int32 b = sheet[0].Length;
        Int32 [,] newSheet = new Int32[b, a];
        
        // Original Array Loop
        for (Int32 i = 0; i < a; i++) {
            for (Int32 j = 0; j < b; j++) {
                newSheet[j,i] = sheet[i][j];
                Console.Write(sheet[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Transposed ForLoop
        for (Int32 i = 0; i < b; i++) {
            for (Int32 j = 0; j < a; j++) {
                Console.Write(newSheet[i,j] + " ");
                
            }
            Console.WriteLine();
        }
    }
}