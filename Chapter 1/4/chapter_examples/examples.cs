using System;

public class example
{
    public static void Main(String[] args)
    {
        String[] SUITS = { "Clubs", "Diamonds", "Hearts", "Spades" };
        String[] RANKS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        String[] deck = new String[RANKS.Length * SUITS.Length];
        for (int i = 0; i < RANKS.Length; i++)
            for (int j = 0; j < SUITS.Length; j++)
            {
                deck[SUITS.Length * i + j] = RANKS[i] + " of " + SUITS[j];
            }
        // Random Card Functionality
        Random card = new Random();
        // Select one of the 52 Cards at random and store it inside a new Integer
        Int32 card_random = card.Next(0, 52);

        // 
        
        Console.WriteLine(
                deck[card_random]
            );
        // Hand _ = card + card + card + card + card

    }
}