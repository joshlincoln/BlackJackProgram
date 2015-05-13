using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        //fields
        public Dictionary<string, int> FACES = new Dictionary<string, int>();
        public string suit;
        private int value;
        public string faceS;
        public int faceI;

        //constructors
        public Card(string face, int face1, string suit) {
            this.faceS = face;
            this.faceI = face1;
            this.suit = suit;
        }   
    }
}
