using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Card
    {
        public Suit suit;
        public Rank rank;
    
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Card()
        {
            
        }

        public string ToString()
        {
            return "The" + rank + " of" + suit + "s";
        }
    }
}
