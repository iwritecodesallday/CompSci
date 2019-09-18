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
        Random card = new Random();
        Int32 card_random = card.Next(0, 52);



        Console.WriteLine(
            "Hand: " +
            deck[card_random]
            );



        // Hand _ = card + card + card + card + card

    }
}