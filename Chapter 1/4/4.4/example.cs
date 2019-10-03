using System;

// Write a code fragment that reverses the order of the values in a one
// dimensional array. Do not create another array to hold the result.

public class example
{
    public static void Main(string[] args)
    {

        int[] arr = { 1, 3, 4, 9, 8 };
        for (int i = 0; i < arr.Length / 2; i++)
        {
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            Console.WriteLine(string.Join(", ", arr));
        }



    }
}