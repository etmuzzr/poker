using System;

namespace CardEngine
{
    class Card
    {
        Rank rank;
        Suit suit;
        string colour;
        public Card(Rank rank, Suit suit) {
            this.rank = rank;
            this.suit = suit;
            this.colour = ((int) suit % 2 == 0) ? "Red" : "Black";
        }

        public override string ToString()
        {
            return $"{rank} of {suit} | {colour}";
        }
    }
    enum Suit
    {
        Hearts = 0,
        Spades = 1,
        Diamonds = 2,
        Clubs = 3
    }

    enum Rank
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}