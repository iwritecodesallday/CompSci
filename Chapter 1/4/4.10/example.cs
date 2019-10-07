using System;

public class deal
{
    public static void Main(string[] args)
    {
        // Deck Modal
        String[] SUITS = { "Clubs", "Diamonds", "Hearts", "Spades" };
        String[] RANKS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        String[] deck = new String[RANKS.Length * SUITS.Length];
        for (int i = 0; i < RANKS.Length; i++)
            for (int j = 0; j < SUITS.Length; j++)
                deck[SUITS.Length * i + j] = RANKS[i] + " of " + SUITS[j];

        // m = cards in hand
        // n = cards in deck
        Int32 m = 5;
        Int32 n = 52;

        Int32[] perm = new int[n];
        Random random = new Random();

        // Without this for loop, card is the same and is drawn 5 times
        for (int j = 0; j < n; j++)
        {
            perm[j] = j;
        }

        // Without this loop, cards are drawn in order
        for (int i = 0; i < m; i++)
        {
            int r = i + (int)(random.Next(n - i));
            int t = perm[r];
            perm[r] = perm[i];
            perm[i] = t;
        }

        // Without this loop, cards are not drawn
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(deck[perm[i]]);
        }
        Console.WriteLine();


    }


    // Question:
    // Write a program "Deal" that takes an integer command-line argument "n" and prints "n poker hands" 
    // (five cards each) from a shuffled deck, seperated by blank lines

    // Answer:
    // 
}
