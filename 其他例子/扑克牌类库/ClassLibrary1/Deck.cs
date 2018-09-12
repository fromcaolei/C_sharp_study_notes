using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibrary1
{
    public class Deck
    {
        private ClassLibrary1.Card[] cards;
    
        public Deck()
        {
            cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        public Card GetCard(int card)
        {
            if (card >= 0 && card <= 51)
                return cards[card];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", card, "Valve must be between 0 and 51."));
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigend = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigend[destCard] == false)
                        foundCard = true;
                }
                assigend[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}
