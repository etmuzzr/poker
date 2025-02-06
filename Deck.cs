using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CardEngine
{
    class Deck 
    {
        private Card[] deck;
        private int deckSize = -1; //The current size of the deck (will point to the last element in a deck)
        private bool canGenerate;

        public Deck(int deckSize, bool generate) {
            this.deck = new Card[deckSize];
            this.canGenerate = (deckSize == 52) && generate;

            if (generate) {
                generateDeck();
                shuffleDeck();
            }

            Console.WriteLine(deck[0]);
        }

        public void addCardToDeck(Card card) {
            int n = deck.Length;
            if (deckSize == n) {return;}

            deckSize++; 
            deck[deckSize] = card;
        }

        public void popCardFromDeck() {
            //I guess we can just implicitly 'pop' from the top of the deck by moving down the deck
            //I'm not expecting this to work well lol
            deckSize--;
        }

        public void generateDeck() {
            if (!canGenerate) {return;}

            foreach (Rank rank in Enum.GetValues(typeof(Rank))) {
                foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
                   addCardToDeck(new Card(rank, suit));
                }
            }
        }

        //Fisher-Yates shuffle B)
        public void shuffleDeck() {
            Random rand = new Random();

            for (int i = deckSize; i > 0; i--) {
                int j = rand.Next(0, i);
                Card tmp = deck[i];
                deck[i] = deck[j];
                deck[j] = tmp;
            }
        }

        public Card[] getDeck() {
            return deck;
        }

        public int getDeckSize() {
            return deckSize;
        }
    }
}