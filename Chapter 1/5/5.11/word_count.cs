using System;
public class word_count
{
    public static void Main()
    {
        string str;
        int words, length;

        str = Console.ReadLine();

        length = 0;
        words = 1;

        // Loop until the end of the string (str.Length - 1)
        while (length <= str.Length - 1)
        {
            // If the Character is a empty, a new line, or if there is a tab
            if (str[length] == ' ' || str[length] == '\n' || str[length] == '\t')
            {
                words++;
            }

            length++;
        }

        Console.Write("Total number of words in the string is : {0}\n", words);
    }
}