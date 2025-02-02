using System;
using CardEngine;

namespace Poker 
{
    class Game
    {
        static void Main(String[] args) {
            Card[] deck = new Card[52];
            
            int i = 0;
            foreach (Rank rank in Enum.GetValues(typeof(Rank))) {
                foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
                    deck[i] = new Card(rank, suit);
                    Console.WriteLine(deck[i].ToString());
                    i++;
                }
            }
            
        }
    }
}