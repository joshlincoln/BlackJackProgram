using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        //Fields
        List<Card> cards;

        public Deck() { 
        cards = new List<Card>();
        }

        public void shuffle(){

        }
        public Card nextCard()
        {
            int i = 0;
            while (cards.Capacity > 0)
            {
                return new cards.IndexOf(i);
                i++;
            }

        }
    }
}
