using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        // constructors
        public Player(String name, int credit){
            this.name = name;
            this.credit = credit;
        }
        public Player(){}

        // fields
        public int credit;
        public Hand hand = new Hand();
        public String name;
        public Dictionary<String, int> stats = new Dictionary<string,int>();

        // setters/getters
        public void setCredit(int credit){
            this.credit = credit;
        }
        public int getCredit()
        {
            return credit;
        }
        public void setHand(Hand hand){
            this.hand = hand;
        }
        public Hand getHand()
        {
            return hand;
        }
        public void setName(String name){
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        

        // methods
        public void play(){

        }

        public String showHand()
        {
            return hand.get;
        }



    }
}
