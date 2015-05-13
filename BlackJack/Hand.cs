using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        List<Card> hand = new List<Card>();
        int value;
        
        // constructors
        public Hand(List<Card> cards)
        {
            this.hand = cards;
        }
        public Hand(){}
        
        // getters / setters
        public List<Card> getHand(){
            return hand;
        }
        public int getvalue()
        {
            return value;
        }

        public void setHand(List<Card> cards){
            this.hand = cards;
        }
        public void setValue(int v)
        {
            this.value = v;
        }


        // methods
        public void drawFrom(Deck deck){

        }
        public void returnTo(Deck deck)
        {

        }


        


    }
}
