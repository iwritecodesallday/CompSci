using System;

// Write a code fragment that reverses the order of the values in a one
// dimensional array. Do not create another array to hold the result.

public class example
{
    public static void Main(string[] args)
    {

        int[] arr = { 1, 3, 4, 9, 8 };

        for (int i = 0; i < arr.Length / 2; i++)
        // If its an odd number, the middle will remain the same
        {
            {
                int tmp = arr[i];
                Console.WriteLine(tmp);
                // 
                arr[i] = arr[arr.Length - i - 1];
                // 2 - i - 1
                
                Console.WriteLine(arr[i]);
                // 
                arr[arr.Length - i - 1] = tmp;
                Console.WriteLine(tmp);
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        



    }
}