using System;

public class deal
{
    public static void Main(string[] args)
    {
        Random ran = new Random();
        // All Suits
        String[] SUITS = {"Clubs", "Diamonds", "Hearts", "Spades"};
        String[] RANKS = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
    
        int i = (int) (ran.Next(1, RANKS.Length));
        int j = (int) (ran.Next(1, SUITS.Length));

        String[] HANDS = new String[RANKS[i] + " of " + SUITS[j]];
        for (int a = 0; a < RANKS.Length; a++) {
            Console.WriteLine(HANDS[0]);
        }
    }
    // Question:
    // Write a program "Deal" that takes an integer command-line argument "n" and prints "n poker hands" 
    // (five cards each) from a shuffled deck, seperated by blank lines

    // Answer:
    // 
}